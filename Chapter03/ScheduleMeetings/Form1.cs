using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleMeetings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display the time zones.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Don't hide the selection when the ListView doesn't have focus.
            timesListView.HideSelection = false;
            timesListView.FullRowSelect = true;

            // List the time zones.
            foreach (TimeZoneInfo info in TimeZoneInfo.GetSystemTimeZones())
            {
                timeZone0ComboBox.Items.Add(info);
                timeZone1ComboBox.Items.Add(info);
            }

            // In the first ComboBox, select the computer's time zone.
            timeZone0ComboBox.SelectedItem = TimeZoneInfo.Local;

            // In the second ComboBox, select the first time zone.
            timeZone1ComboBox.SelectedIndex = 0;

            // Display the first time chart.
            MakeTimeChart();
        }

        // Make a new time chart.
        private void timeZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeTimeChart();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MakeTimeChart();
        }

        // Make the time chart.
        private void MakeTimeChart()
        {
            timesListView.Items.Clear();

            // Make sure we have the values we need.
            if (timeZone0ComboBox.SelectedIndex == -1) return;
            if (timeZone1ComboBox.SelectedIndex == -1) return;

            // Get the selected time zones.
            TimeZoneInfo timeZone0 = timeZone0ComboBox.SelectedItem as TimeZoneInfo;
            TimeZoneInfo timeZone1 = timeZone1ComboBox.SelectedItem as TimeZoneInfo;

            // Get midnight in the time zones.
            DateTime time0 = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                0, 0, 0, DateTimeKind.Unspecified);
            DateTime time1 = TimeZoneInfo.ConvertTime(time0, timeZone0, timeZone1);

            // Display the time zone names in the ListView column headers.
            if (timeZone0.IsDaylightSavingTime(time0))
                timesListView.Columns[0].Text = timeZone0.DaylightName;
            else
                timesListView.Columns[0].Text = timeZone0.StandardName;

            if (timeZone1.IsDaylightSavingTime(time1))
                timesListView.Columns[1].Text = timeZone1.DaylightName;
            else
                timesListView.Columns[1].Text = timeZone1.StandardName;

            // Process 24 hours.
            for (int hour = 1; hour <= 24; hour++)
            {
                // Display the time in the first time zone.
                string text0 = time0.ToShortTimeString();
                if (timeZone0.IsAmbiguousTime(time0)) text0 += " [AMBIGUOUS]";
                if (timeZone0.IsInvalidTime(time0)) text0 += " [INVALID]";
                ListViewItem item = timesListView.Items.Add(text0);

                // Display the time in the second time zone.
                if (!timeZone0.IsInvalidTime(time0))
                {
                    time1 = TimeZoneInfo.ConvertTime(time0, timeZone0, timeZone1);
                    string text1 = time1.ToShortTimeString();
                    if (timeZone1.IsAmbiguousTime(time1)) text1 += " [AMBIGUOUS]";
                    if (timeZone1.IsInvalidTime(time1)) text1 += " [INVALID]";
                    if (time0.Date < time1.Date) text1 += " (tomorrow)";
                    else if (time0.Date > time1.Date) text1 += " (yesterday)";
                    item.SubItems.Add(text1);

                    // Highlight the row if both hours are valid, unambiguous, and between 9 AM and 4 PM.
                    if ((time0.Hour >= 9) && (time0.Hour <= 16) &&
                        (time1.Hour >= 9) && (time1.Hour <= 16) &&
                        !timeZone0.IsAmbiguousTime(time0) &&
                        !timeZone1.IsAmbiguousTime(time1) &&
                        !timeZone1.IsInvalidTime(time1))
                        item.BackColor = Color.LightBlue;
                    else
                        item.BackColor = Color.Pink;
                }

                // Move to the next hour.
                time0 = time0.AddHours(1);
            }

            // Select the current hour.
            DateTime localTime = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                DateTime.Now.Hour,
                0, 0, DateTimeKind.Unspecified);
            localTime = TimeZoneInfo.ConvertTime(localTime,
                TimeZoneInfo.Local, timeZone0);
            timesListView.Items[localTime.Hour].Selected = true;
            timesListView.EnsureVisible(localTime.Hour);
        }
    }
}
