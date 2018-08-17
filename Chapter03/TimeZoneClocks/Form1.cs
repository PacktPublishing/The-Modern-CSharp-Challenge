using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZoneClocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Arrays holding the clock labels and their TimeZoneInfo objects.
        private Label[] ClockLabels;
        private TimeZoneInfo[] TimeZoneInfos;

        // Initialize the clock labels and time zone IDs.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Save references to the clock labels.
            ClockLabels = new Label[]
            {
                newYorkLabel,
                parisLabel,
                londonLabel,
                tokyoLabel,
                sydneyLabel,
            };

            // Get the corresponding TimeZoneInfo objects.
            string[] ids =
            {
                "Eastern Standard Time",
                "Romance Standard Time",
                "GMT Standard Time",
                "Tokyo Standard Time",
                "AUS Eastern Standard Time",
            };
            TimeZoneInfos = new TimeZoneInfo[ids.Length];
            for (int i = 0; i < ids.Length; i++)
                TimeZoneInfos[i] = TimeZoneInfo.FindSystemTimeZoneById(ids[i]);

            // Start the timer.
            clockTimer.Enabled = true;
        }

        // Display the time in the various time zones.
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // Get the current time.
            DateTime utcTime = DateTime.UtcNow;

            // Display the times.
            for (int i = 0; i < ClockLabels.Length; i++)
            {
                DateTime time = TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfos[i]);
                ClockLabels[i].Text = time.ToLongTimeString();
            }
        }
    }
}
