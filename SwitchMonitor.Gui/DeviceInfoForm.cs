using SwitchMonitor.Db;
using System;
using System.Windows.Forms;

namespace SwitchMonitor
{
    public partial class DeviceInfoForm : Form
    {
        private readonly Device device;

        private readonly EventsOLV eventsOLV;

        private bool inEditMode;

        public bool ChangesHappened
        {
            get;
            private set;
        }

        private bool isNewDevice;

        public DeviceInfoForm(Device device, bool newDevice = false)
        {
            InitializeComponent();

            this.device = device;

            UpdateFieldsFromData();

            lock (Database.Lock) using (var db = Database.GetConnection())
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

            eventsOLV = new EventsOLV(
                db => db.Table<Event>().Where(e => e.DeviceId == this.device.Id).OrderBy(e => e.Time),
                EventsOLV.EventColumns.Date | EventsOLV.EventColumns.Status)
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
            };
            eventsGroupBox.Controls.Add(eventsOLV);

            if (newDevice)
            {
                SetEditMode(true);
                isNewDevice = true;
            }
        }

        private void UpdateFieldsFromData()
        {
            deviceNameBox.Text = device.Name;
            deviceAddressBox.Text = device.Address;
            descriptionBox.Text = device.Description;
        }

        public void SetEditMode(bool editMode)
        {
            inEditMode = editMode;

            editButton.Enabled = !editMode;
            saveButton.Enabled = editMode;
            saveButton.Visible = editMode;
            revertButton.Enabled = editMode;
            revertButton.Visible = editMode;

            deviceNameBox.ReadOnly = !editMode;
            deviceAddressBox.ReadOnly = !editMode;
            descriptionBox.ReadOnly = !editMode;
        }

        private bool SaveData()
        {
            if (string.IsNullOrWhiteSpace(deviceAddressBox.Text) || string.IsNullOrWhiteSpace(deviceNameBox.Text))
            {
                MessageBox.Show(this,
                                text: "חסרים פרטים.",
                                caption: "חסרים פרטים",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Warning,
                                defaultButton: MessageBoxDefaultButton.Button1,
                                options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return false;
            }

            var address = deviceAddressBox.Text;

            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    var existingDevice = db.Table<Device>().Where(d => d.Id != device.Id && d.Address == address).FirstOrDefault();
                    if (existingDevice != null)
                    {
                        MessageBox.Show(this,
                                        text: $"כבר קיים רכיב בשם \"{existingDevice.Name}\" עם הכתובת {address}.",
                                        caption: "הרכיב כבר קיים",
                                        buttons: MessageBoxButtons.OK,
                                        icon: MessageBoxIcon.Warning,
                                        defaultButton: MessageBoxDefaultButton.Button1,
                                        options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        return false;
                    }

                    device.Address = deviceAddressBox.Text;
                    device.Name = deviceNameBox.Text;
                    device.Description = descriptionBox.Text;

                    if (isNewDevice)
                    {
                        db.Insert(device);
                        isNewDevice = false;
                    }
                    else
                    {
                        db.Update(device);
                    }
                }

            ChangesHappened = true;
            SetEditMode(false);

            return true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            UpdateFieldsFromData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void deviceAddressBox_Click(object sender, EventArgs e)
        {
            if (deviceAddressBox.ReadOnly)
            {
                deviceAddressBox.SelectAll();
            }
        }

        private void DeviceInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inEditMode)
            {
                var result = MessageBox.Show(this,
                                         text: "לשמור את השינויים לרכיב?",
                                         caption: "שינויים",
                                         buttons: MessageBoxButtons.YesNoCancel,
                                         icon: MessageBoxIcon.Information,
                                         defaultButton: MessageBoxDefaultButton.Button1,
                                         options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {
                    var success = SaveData();
                    e.Cancel = !success;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
