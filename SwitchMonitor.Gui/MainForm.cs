using SwitchMonitor.Db;
using System;
using System.Collections.Generic;
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

        public MainForm()
        {
            InitializeComponent();

            PopulateDevicesListView();

            this.eventsOLV = new EventsOLV(db => db.Table<Event>().Where(e => !e.Acknowledged), EventsOLV.EventColumns.AllWithButton)
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
            };

            devicesImageList = new ImageList() { ImageSize = new Size(64, 64) };
            devicesImageList.Images.Add("deviceUp", Properties.Resources.deviceUp);
            devicesImageList.Images.Add("deviceDown", Properties.Resources.deviceDown);
            devicesImageList.Images.Add("deviceUnknown", Properties.Resources.deviceUnknown);

            devicesListView.LargeImageList = devicesImageList;

            eventsGroupBox.Controls.Add(this.eventsOLV);
        }

        public void PopulateDevicesListView()
        {
            devicesListView.Items.Clear();
            deviceItems = new Dictionary<int, ListViewItem>();
            using (var db = Database.GetConnection())
            {
                var devices = db.Table<Device>();
                foreach (var device in devices)
                {
                    var status = db.GetLastDeviceStatus(device);
                    var item = devicesListView.Items.Add(device.Id.ToString(), device.Name, DeviceStatusImageKey(status));
                    item.Tag = device;
                    item.Group = DeviceStatusGroup(status);
                    deviceItems[device.Id] = item;
                }
            }
        }

        private void addDeviceMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new EditDeviceForm();
            using (var db = Database.GetConnection())
            {
            ShowAgain:
                var result = dialog.ShowDialog(this);
                if (result != DialogResult.OK)
                {
                    return;
                }

                var newDevice = new Device() { Address = dialog.Address, Name = dialog.DeviceName };
                var existingDevice = db.Table<Device>().Where(d => d.Address == newDevice.Address).FirstOrDefault();
                if (existingDevice != null)
                {
                    MessageBox.Show(this,
                                    text: $"כבר קיים רכיב בשם \"{existingDevice.Name}\" עם אותה הכתובת.",
                                    caption: "הרכיב כבר קיים",
                                    buttons: MessageBoxButtons.OK,
                                    icon: MessageBoxIcon.Warning,
                                    defaultButton: MessageBoxDefaultButton.Button1,
                                    options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    goto ShowAgain;
                }

                db.Insert(newDevice);
                PopulateDevicesListView();
                DevicePoller.RefreshDevices();
            }
        }

        private void statusChangeTimer_Tick(object sender, EventArgs e)
        {
            while (DevicePoller.statusChangeQueue.TryDequeue(out DeviceStatusChange change))
            {
                var item = deviceItems[change.Device.Id];
                item.Group = DeviceStatusGroup(change.Status);
                item.ImageKey = DeviceStatusImageKey(change.Status);

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
                editToolStripItem.Enabled = !multipleSelected;
                showInfoToolStripItem.Enabled = !multipleSelected;
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
                using (var db = Database.GetConnection())
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

        private void OpenDeviceInfo(Device device)
        {
            new DeviceInfoForm(device).ShowDialog(this);
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
    }
}
