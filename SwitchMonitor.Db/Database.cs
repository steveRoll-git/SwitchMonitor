using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchMonitor.Db
{
    public enum DeviceStatus
    {
        Up,
        Down,
        Unknown
    }

    [Table("devices")]
    public class Device
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }

    [Table("events")]
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int DeviceId { get; set; }

        public string DeviceName { get; set; }

        [Unique]
        public string DeviceAddress { get; set; }

        public DeviceStatus Status { get; set; }

        [NotNull]
        public bool Acknowledged { get; set; }

        public DateTime AcknowledgedAt { get; set; }

        public Event(DateTime time, Device device, DeviceStatus status)
        {
            Time = time;
            Status = status;
            DeviceId = device.Id;
            DeviceName = device.Name;
            DeviceAddress = device.Address;
            Acknowledged = false;
        }

        public Event()
        {

        }

        public void Acknowledge()
        {
            Acknowledged = true;
            AcknowledgedAt = DateTime.Now;
        }
    }

    public static class Database
    {
        public static string ConnectionString =>
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "SwitchMonitorDatabase");

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.CreateTable<Device>();
                connection.CreateTable<Event>();
            }
        }

        static Database()
        {
            CreateTables();
        }

        public static DeviceStatus GetLastDeviceStatus(this SQLiteConnection connection, Device device)
        {
            var events = connection.Table<Event>()
                .Where(e => e.DeviceId == device.Id)
                .OrderByDescending(e => e.Time);
            return events.FirstOrDefault()?.Status ?? DeviceStatus.Unknown;
        }
    }
}
