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

namespace DateAndTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Make the DateTimePicker use a custom format
        // that includes both date and time in localized long formats.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Uncomment to test in German.
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");

            // Get the computer's culture info.
            CultureInfo info = Thread.CurrentThread.CurrentCulture;

            // Set the format to use long date and short time.
            dateAndTimePicker.Format = DateTimePickerFormat.Custom;
            dateAndTimePicker.CustomFormat =
                info.DateTimeFormat.LongDatePattern + "    " +
                info.DateTimeFormat.ShortTimePattern;

            // Display the initial date and time.
            dateAndTimeLabel.Text = dateAndTimePicker.Value.ToString("F");
        }

        // Display the selected date and time in long formats.
        private void dateAndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateAndTimeLabel.Text = dateAndTimePicker.Value.ToString("F");
        }
    }
}
