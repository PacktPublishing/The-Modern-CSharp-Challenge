using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysOfTheWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Do not allow the user to select a range.
        private void Form1_Load(object sender, EventArgs e)
        {
            birthdateMonthCalendar.MaxSelectionCount = 1;
        }

        // Show the next 10 birthdays.
        private void goButton_Click(object sender, EventArgs e)
        {
            datesListBox.Items.Clear();

            // Get the birthdate.
            DateTime birthdate = birthdateMonthCalendar.SelectionStart;

          // Get the first birthdate that is today or later.
            DateTime startdate = new DateTime(
                DateTime.Now.Year,
                birthdate.Month,
                birthdate.Day);
            if (startdate < DateTime.Now)
                startdate = startdate.AddYears(1);

            // Display the next 10 birthdays.
            for (int i = 0; i < 10; i++)
            {
                datesListBox.Items.Add(
                    startdate.AddYears(i).ToLongDateString());
            }
        }
    }
}
