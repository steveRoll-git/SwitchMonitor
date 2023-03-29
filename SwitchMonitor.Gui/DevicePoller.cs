using SwitchMonitor.Db;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwitchMonitor
{
    public class DeviceStatusChange
    {
        public Device Device;
        public DeviceStatus Status;
    }

    static class DevicePoller
    {
        /// <summary>
        /// How often to run pings for every device, in milliseconds.
        /// </summary>
        public static int pollInterval = 0;

        static List<Device> devices;
        static readonly Dictionary<string, DeviceStatus> lastStatuses = new Dictionary<string, DeviceStatus>();

        public static ConcurrentQueue<DeviceStatusChange> statusChangeQueue = new ConcurrentQueue<DeviceStatusChange>();

        public delegate void DeviceStatusChangeHandler(Device device, DeviceStatus status);

        private static DeviceStatus IPStatusToDevice(IPStatus status)
        {
            switch (status)
            {
                case IPStatus.Success:
                    return DeviceStatus.Up;
                default:
                    return DeviceStatus.Down;
            }
        }

        public static void RefreshDevices()
        {
            using (var db = Database.GetConnection())
            {
                devices = db.Table<Device>().ToList();
            }
        }

        public static void PollDevices()
        {
            // only a single instance of the device poller should be running
            var instanceMutex = new Mutex(true, "SwitchMonitorPoller", out bool isNew);
            if (!isNew)
            {
                return;
            }

            RefreshDevices();
            using (var pinger = new Ping())
            {
                while (true)
                {
                    foreach (var device in devices)
                    {
                        if (!lastStatuses.ContainsKey(device.Address))
                        {
                            using (var db = Database.GetConnection())
                            {
                                lastStatuses[device.Address] = db.GetLastDeviceStatus(device);
                            }
                        }
                        DeviceStatus currentStatus = DeviceStatus.Unknown;
                        try
                        {
                            currentStatus = IPStatusToDevice(pinger.Send(device.Address).Status);
                        }
                        catch (Exception)
                        {
                            currentStatus = DeviceStatus.Down;
                        }

                        if (currentStatus != lastStatuses[device.Address])
                        {
                            var newEvent = new Event(DateTime.Now, device, currentStatus);
                            using (var db = Database.GetConnection())
                            {
                                db.Insert(newEvent);
                                lastStatuses[device.Address] = currentStatus;
                                statusChangeQueue.Enqueue(new DeviceStatusChange() { Device = device, Status = currentStatus });
                            }
                        }
                    }

                    Thread.Sleep(pollInterval);

                    GC.KeepAlive(instanceMutex);
                }
            }
        }
    }
}
