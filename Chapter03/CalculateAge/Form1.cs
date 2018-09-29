using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display the age.
        private void Form1_Load(object sender, EventArgs e)
        {
            birthdatePicker.Value = new DateTime(2000, 4, 1);
            ShowAge();
        }
        private void birthdatePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowAge();
        }
        private void ShowAge()
        {
            int years, months, days;
            CalculateElapsedYMD(birthdatePicker.Value.Date, DateTime.Today,
                out years, out months, out days);
            yearsLabel.Text = years.ToString();
            monthsLabel.Text = months.ToString();
            daysLabel.Text = days.ToString();
        }

        // Calculate the years, months, and days between the two dates.
        private void CalculateElapsedYMD(DateTime startDate, DateTime endDate,
            out int years, out int months, out int days)
        {
            // Years.
            years = endDate.Year - startDate.Year;
            if (startDate.AddYears(years) > endDate) years--;
            startDate = startDate.AddYears(years);

            // Months.
            months = endDate.Month - startDate.Month;
            if (endDate.Year > startDate.Year) months += 12;
            if (startDate.AddMonths(months) > endDate) months--;
            startDate = startDate.AddMonths(months);

            // Days.
            days = (endDate - startDate).Days;
        }
    }
}
