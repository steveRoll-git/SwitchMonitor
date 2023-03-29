using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchMonitor
{
    static class Program
    {
        static Thread pollerThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // only a single instance of the program should be running
            var instanceMutex = new Mutex(true, "SwitchMonitorGui", out bool isNew);
            if (!isNew)
            {
                return;
            }

            pollerThread = new Thread(new ThreadStart(DevicePoller.PollDevices));
            pollerThread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            GC.KeepAlive(instanceMutex);
        }
    }
}
