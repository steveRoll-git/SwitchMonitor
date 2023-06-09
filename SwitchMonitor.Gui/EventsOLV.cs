﻿using BrightIdeasSoftware;
using SQLite;
using SwitchMonitor.Db;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SwitchMonitor
{
    internal class EventsOLV : FastObjectListView
    {
        [Flags]
        public enum EventColumns
        {
            Date = 0x1,
            DeviceName = 0x2,
            Status = 0x4,
            DateAcknowledged = 0x8,
            AcknowledgeButton = 0xf1,
            All = Date | DeviceName | Status,
            AllDetailed = Date | DeviceName | Status | DateAcknowledged,
            AllWithButton = Date | DeviceName | Status | AcknowledgeButton,
        }

        private readonly Func<SQLiteConnection, IEnumerable<Event>> eventSource;

        public EventsOLV(Func<SQLiteConnection, IEnumerable<Event>> eventSource, EventColumns eventColumns) : base()
        {
            this.eventSource = eventSource;

            if (eventColumns.HasFlag(EventColumns.Date))
            {
                this.Columns.Add(new OLVColumn("תאריך", "Time")
                {
                    Width = 130,
                });
            }

            if (eventColumns.HasFlag(EventColumns.DeviceName))
            {
                this.Columns.Add(new OLVColumn("רכיב", "DeviceName")
                {
                    Width = 110,
                    FillsFreeSpace = true,
                });
            }

            if (eventColumns.HasFlag(EventColumns.Status))
            {
                this.Columns.Add(new OLVColumn("מצב", "Status")
                {
                    AspectToStringConverter = delegate (object row)
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
                    }
                });
            }

            if (eventColumns.HasFlag(EventColumns.DateAcknowledged))
            {
                this.Columns.Add(new OLVColumn("סומן ב-✓ בתאריך", "AcknowledgedAt")
                {
                    Width = 130,
                    AspectGetter = (e) =>
                    {
                        var theEvent = (Event)e;
                        if (theEvent.Acknowledged)
                        {
                            return theEvent.AcknowledgedAt;
                        }
                        else
                        {
                            return "---";
                        }
                    }
                });
            }

            if (eventColumns.HasFlag(EventColumns.AcknowledgeButton))
            {
                this.Columns.Add(new OLVColumn()
                {
                    Text = "אוקיי",
                    AspectName = "Acknowledged",
                    AspectToStringFormat = "✓",
                    IsButton = true,
                    ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds,
                    Width = 40,
                    Sortable = false,
                });

                ButtonClick += EventsOLV_ButtonClick;
            }

            FormatRow += EventsOLV_FormatRow;

            UpdateItems();
        }

        private void EventsOLV_ButtonClick(object sender, CellClickEventArgs e)
        {
            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    var theEvent = (Event)e.Model;
                    theEvent.Acknowledge();
                    db.Update(theEvent);

                    UpdateItems();
                }
        }

        private void EventsOLV_FormatRow(object sender, FormatRowEventArgs e)
        {
            FormatEventRow(e.Item);
        }

        public void UpdateItems()
        {
            lock (Database.Lock) using (var db = Database.GetConnection())
                {
                    SetObjects(eventSource(db));
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
    }
}
