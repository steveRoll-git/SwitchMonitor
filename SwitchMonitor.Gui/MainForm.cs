using BrightIdeasSoftware;
using SwitchMonitor.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public MainForm()
        {
            InitializeComponent();

            PopulateDevicesListView();

            StatusColumn.AspectToStringConverter = delegate (object row)
            {
                var status = (DeviceStatus)row;
                switch (status)
                {
                    case DeviceStatus.Up:
                        return "תקין";
                    case DeviceStatus.Down:
                        return "לא תקין";
                    default:
                        return "לא ידוע";
                }
            };

            UpdateEventItems();
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

        private void UpdateEventItems()
        {
            using (var db = Database.GetConnection())
            {
                olvEvents.SetObjects(db.Table<Event>().Where(e => e.Acknowledged == null || !e.Acknowledged));
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

        private void FormatEventRow(OLVListItem item)
        {
            switch (((Event)item.RowObject).Status)
            {
                case DeviceStatus.Up:
                    item.BackColor = Color.LightGreen;
                    break;
                case DeviceStatus.Down:
                    item.BackColor = Color.FromArgb(255, 100, 100);
                    break;
                default:
                    item.BackColor = Color.Gray;
                    break;
            }
        }

        private void olvEvents_FormatRow(object sender, FormatRowEventArgs e)
        {
            FormatEventRow(e.Item);
        }

        private void olvEvents_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            foreach (OLVListItem item in olvEvents.Items)
            {
                FormatEventRow(item);
            }
        }

        private void olvEvents_ButtonClick(object sender, CellClickEventArgs e)
        {
            using (var db = Database.GetConnection())
            {
                var theEvent = (Event)e.Model;
                theEvent.Acknowledged = true;
                db.Update(theEvent);
                UpdateEventItems();
            }
        }
    }
}
