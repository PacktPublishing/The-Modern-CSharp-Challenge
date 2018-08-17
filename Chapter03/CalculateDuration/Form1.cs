using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;

namespace CalculateDuration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Prepare the DateTimePickers.
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("DE-de");

            // Make the DateTimePickers select long date and short time.
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat =
                info.DateTimeFormat.LongDatePattern + "    " +
                info.DateTimeFormat.ShortTimePattern;

            stopDatePicker.Format = DateTimePickerFormat.Custom;
            stopDatePicker.CustomFormat =
                info.DateTimeFormat.LongDatePattern + "    " +
                info.DateTimeFormat.ShortTimePattern;

            // Initially select times spanning Daylight Savings Time start.
            startDatePicker.Value = new DateTime(2020, 3, 7, 13, 0, 0);
            stopDatePicker.Value = new DateTime(2020, 3, 8, 13, 0, 0);
        }

        // Display the duration between the two dates and times.
        private void findDurationButton_Click(object sender, EventArgs e)
        {
            DateTime localStart = startDatePicker.Value;
            DateTime localStop = stopDatePicker.Value;
            TimeSpan localInterval = localStop - localStart;
            localIntervalLabel.Text = localInterval.TotalHours.ToString() + " hours";

            DateTime utcStart = localStart.ToUniversalTime();
            DateTime utcStop = localStop.ToUniversalTime();
            TimeSpan utcInterval = utcStop - utcStart;
            utcIntervalLabel.Text = utcInterval.TotalHours.ToString() + " hours";
        }
    }
}
