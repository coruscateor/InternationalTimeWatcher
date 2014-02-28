using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InternationalTimeWatcher
{

    public partial class InternationalTimeWatcherForm : Form
    {

        TimeZoneInfo mySelectedTimeZone;

        public InternationalTimeWatcherForm()
        {

            InitializeComponent();

            Icon = InternationalTimeWatcher.Properties.Resources.TimeClock;

            FormClosing += InternationalTimeWatcherForm_FormClosing;

            ClockTimer.Tick += ClockTimer_Tick;

            TimeZonesComboBox.SelectedIndexChanged += TimeZonesComboBox_SelectedIndexChanged;

            mySelectedTimeZone = TimeZoneInfo.Local;

            TimeZonesComboBox.BeginUpdate();

            foreach (var Item in TimeZoneInfo.GetSystemTimeZones())
            {

                TimeZonesComboBox.Items.Add(Item);

            }

            for (int i = 0; i < TimeZonesComboBox.Items.Count; i++)
            {

                if (mySelectedTimeZone.Id == ((TimeZoneInfo)TimeZonesComboBox.Items[i]).Id)
                {

                    TimeZonesComboBox.SelectedIndex = i;

                }

            }

            TimeZonesComboBox.EndUpdate();
            
            ClockTimer.Enabled = true;

        }

        void TimeZonesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            TimeZoneInfo SelectedTimeZoneInfoItem = (TimeZoneInfo)TimeZonesComboBox.SelectedItem;

            if (mySelectedTimeZone != SelectedTimeZoneInfoItem)
            {

                mySelectedTimeZone = SelectedTimeZoneInfoItem;

            }

        }

        void ClockTimer_Tick(object sender, EventArgs e)
        {

            DateTime Now = DateTime.Now;

            Text = Now.DayOfWeek + ", " + TimeZoneInfo.ConvertTime(Now, mySelectedTimeZone).ToString() + " - " + mySelectedTimeZone.StandardName;

        }

        void InternationalTimeWatcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            ClockTimer.Tick -= ClockTimer_Tick; 

            FormClosing -= InternationalTimeWatcherForm_FormClosing;

            TimeZonesComboBox.SelectedIndexChanged -= TimeZonesComboBox_SelectedIndexChanged;

        }

    }

}
