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
    public partial class DeviceInfoForm : Form
    {
        private readonly Device device;

        private readonly EventsOLV eventsOLV;

        public DeviceInfoForm(Device device)
        {
            InitializeComponent();

            this.device = device;

            deviceNameLabel.Text = device.Name;
            deviceAddressBox.Text = device.Address;

            using (var db = Database.GetConnection())
            {
                switch (db.GetLastDeviceStatus(device))
                {
                    case DeviceStatus.Up:
                        deviceIcon.Image = Properties.Resources.deviceUp;
                        break;
                    case DeviceStatus.Down:
                        deviceIcon.Image = Properties.Resources.deviceDown;
                        break;
                    default:
                        deviceIcon.Image = Properties.Resources.deviceUnknown;
                        break;
                }
            }

            eventsOLV = new EventsOLV(db => db.Table<Event>().Where(e => e.DeviceId == this.device.Id).OrderBy(e => e.Time), EventsOLV.EventColumns.All)
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
            };
            eventsGroupBox.Controls.Add(eventsOLV);
        }
    }
}
