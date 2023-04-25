using SwitchMonitor.Db;
using System.Windows.Forms;

namespace SwitchMonitor
{
    public partial class EventExplorer : Form
    {
        private EventsOLV eventsOLV;

        public EventExplorer()
        {
            InitializeComponent();

            eventsOLV = new EventsOLV(db => db.Table<Event>(), EventsOLV.EventColumns.AllDetailed)
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
            };
            this.Controls.Add(eventsOLV);
            eventsOLV.EnsureVisible(eventsOLV.Items.Count - 1);
        }
    }
}
