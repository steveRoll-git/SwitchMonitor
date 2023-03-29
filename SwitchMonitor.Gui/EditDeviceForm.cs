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
    public partial class EditDeviceForm : Form
    {
        public string DeviceName => nameInput.Text;
        public string Address => addressInput.Text;

        public EditDeviceForm()
        {
            InitializeComponent();
        }

        private void InputsTextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrWhiteSpace(nameInput.Text) && !String.IsNullOrWhiteSpace(addressInput.Text);
        }
    }
}
