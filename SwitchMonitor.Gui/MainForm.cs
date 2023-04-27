using SQLite;
using SwitchMonitor.Db;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SwitchMonitor
{
    public partial class MainForm : Form
    {
        private static string DeviceStatusImageKey(DeviceStatus status)
        {
            switch (status)
            {
                case DeviceStatus.Up:
                    return "deviceUp";
                case DeviceStatus.Down:
                    return "deviceDown";
                default:
                    return "deviceUnknown";
            }
        }

        private ListViewGroup DeviceStatusGroup(DeviceStatus status)
        {
            switch (status)
            {
                case DeviceStatus.Up:
                    return devicesListView.Groups["DevicesUp"];
                default:
                    return devicesListView.Groups["DevicesDown"];
            }
        }

        private Dictionary<int, ListViewItem> deviceItems;

        private readonly EventsOLV eventsOLV;

        private readonly ImageList devicesImageList;

        private string previousSearchInput = "";

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;
            notifyIcon.Icon = Properties.Resources.icon;

            PopulateDevicesListView();

            this.eventsOLV = new EventsOLV(db => db.Table<Event>().Where(e => !e.Acknowledged), EventsOLV.EventColumns.AllWithButton)
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
            };
            eventsOLV.ButtonClick += EventsOLV_ButtonClick;

            devicesImageList = new ImageList() { ImageSize = new Size(64, 64) };
            devicesImageList.Images.Add("deviceUp", Properties.Resources.deviceUp);
            devicesImageList.Images.Add("deviceDown", Properties.Resources.deviceDown);
            devicesImageList.Images.Add("deviceUnknown", Properties.Resources.deviceUnknown);

            devicesListView.LargeImageList = devicesImageList;

            eventsGroupBox.Controls.Add(this.eventsOLV);
        }

        private void EventsOLV_ButtonClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            var theEvent = (Event)e.Model;
            if (!deviceItems.ContainsKey(theEvent.DeviceId))
            {
                return;
            }
            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    UpdateDeviceGroup(db, (Device)deviceItems[theEvent.DeviceId].Tag);
                }
        }

        public void PopulateDevicesListView()
        {
            devicesListView.Items.Clear();
            deviceItems = new Dictionary<int, ListViewItem>();
            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    var devices = db.Table<Device>();
                    foreach (var device in devices)
                    {
                        var status = db.GetLastDeviceStatus(device);
                        var item = devicesListView.Items.Add(device.Id.ToString(), device.Name, DeviceStatusImageKey(status));
                        item.Tag = device;
                        deviceItems[device.Id] = item;

                        UpdateDeviceGroup(db, device);
                    }
                }
        }

        private void UpdateDeviceStatusGroup(SQLiteConnection db, Device device)
        {
            deviceItems[device.Id].Group = DeviceStatusGroup(db.GetLastDeviceStatus(device));
        }

        private void UpdateDeviceGroup(SQLiteConnection db, Device device)
        {
            if (db.HasUnacknowledgedEvents(device))
            {
                deviceItems[device.Id].Group = devicesListView.Groups["UnacknowledgedEvents"];
            }
            else
            {
                UpdateDeviceStatusGroup(db, device);
            }
        }

        private void OpenDeviceInfo(Device device, bool isNew = false)
        {
            var form = new DeviceInfoForm(device, isNew);
            form.ShowDialog(this);
            if (form.ChangesHappened)
            {
                PopulateDevicesListView();
                eventsOLV.UpdateItems();
                DevicePoller.RefreshDevices();
            }
        }

        private void addDeviceMenuItem_Click(object sender, EventArgs e)
        {
            OpenDeviceInfo(new Device() { PingInterval = 1 }, true);
        }

        private void statusChangeTimer_Tick(object sender, EventArgs e)
        {
            while (DevicePoller.statusChangeQueue.TryDequeue(out DeviceStatusChange change))
            {
                var item = deviceItems[change.Device.Id];
                item.Group = DeviceStatusGroup(change.Status);
                item.ImageKey = DeviceStatusImageKey(change.Status);
                lock (Database.Lock) using (var db = Database.GetConnection())
                    {
                        UpdateDeviceGroup(db, change.Device);
                    }

                eventsOLV.UpdateItems();
            }
        }

        private void devicesListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (devicesListView.SelectedItems.Count == 0)
                {
                    return;
                }
                var multipleSelected = devicesListView.SelectedItems.Count > 1;
                showInfoToolStripItem.Enabled = !multipleSelected;
                pingToolStripItem.Enabled = !multipleSelected;
                deviceContextMenu.Show(Cursor.Position);
            }
        }

        private void deleteToolStripItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this,
                                         text: $"בטוח שברצונך למחוק את הרכיבים האלה? לא יהיה ניתן להחזיר אותם.",
                                         caption: "מחיקת רכיבים",
                                         buttons: MessageBoxButtons.OKCancel,
                                         icon: MessageBoxIcon.Warning,
                                         defaultButton: MessageBoxDefaultButton.Button1,
                                         options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (result == DialogResult.OK)
            {
                lock (Database.Lock) using (var db = Database.GetConnection())
                    {
                        foreach (ListViewItem selected in devicesListView.SelectedItems)
                        {
                            var device = (Device)selected.Tag;
                            db.Delete(device);
                        }
                    }
                DevicePoller.RefreshDevices();
                PopulateDevicesListView();
            }
        }

        private void devicesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (devicesListView.SelectedItems.Count == 1)
            {
                OpenDeviceInfo((Device)devicesListView.SelectedItems[0].Tag);
            }
        }

        private void showInfoToolStripItem_Click(object sender, EventArgs e)
        {
            if (devicesListView.SelectedItems.Count == 1)
            {
                OpenDeviceInfo((Device)devicesListView.SelectedItems[0].Tag);
            }
        }

        private void showAllEventsItem_Click(object sender, EventArgs e)
        {
            new EventExplorer().ShowDialog(this);
        }

        private void acknowledgeAllButton_Click(object sender, EventArgs _)
        {
            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    var unacknowledged = db.Table<Event>().Where(e => !e.Acknowledged).ToList();
                    foreach (var e in unacknowledged)
                    {
                        e.Acknowledge();
                        UpdateDeviceStatusGroup(db, db.Find<Device>(e.DeviceId));
                    }
                    db.UpdateAll(unacknowledged);
                    eventsOLV.UpdateItems();
                }
        }

        /// <summary>
        /// only filters devices that are already shown - assuming
        /// the current filter is a subset of the last one
        /// </summary>
        /// <param name="filter"></param>
        private void FilterDevicesShown(string filter)
        {
            foreach (ListViewItem item in devicesListView.Items)
            {
                var device = (Device)item.Tag;
                if (!(device.Name.Contains(filter) || device.Address.Contains(filter)))
                {
                    devicesListView.Items.Remove(item);
                }
                else
                {
                    item.Group = devicesListView.Groups["SearchResults"];
                }
            }
        }

        private void FilterDevices(string filter)
        {
            devicesListView.Clear();
            foreach (var pair in deviceItems)
            {
                var item = pair.Value;
                var device = (Device)item.Tag;
                if (device.Name.Contains(filter) || device.Address.Contains(filter))
                {
                    devicesListView.Items.Add(item);
                    item.Group = devicesListView.Groups["SearchResults"];
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                PopulateDevicesListView();
                searchPictureBox.Image = Properties.Resources.icon_search;
            }
            else
            {
                if (searchBox.Text.Contains(previousSearchInput))
                {
                    FilterDevicesShown(searchBox.Text);
                }
                else
                {
                    FilterDevices(searchBox.Text);
                }
                searchPictureBox.Image = Properties.Resources.icon_close;
            }

            previousSearchInput = searchBox.Text;
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void pingToolStripItem_Click(object sender, EventArgs e)
        {
            if (devicesListView.SelectedItems.Count == 1)
            {
                Process.Start("cmd.exe", $"/C ping {((Device)devicesListView.SelectedItems[0].Tag).Address} -t");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void BringFormToFront()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            BringFormToFront();
        }
    }
}
