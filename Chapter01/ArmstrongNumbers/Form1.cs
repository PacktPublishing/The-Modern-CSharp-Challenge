using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmstrongNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Find Armstrong numbers.
        private void goButton_Click(object sender, EventArgs e)
        {
            resultListBox.DataSource = null;
            numNumbersLabel.Text = "";
            Refresh();

            long max = long.Parse(maxTextBox.Text);
            List<long> values = FindArmstrongNumbers(max);

            resultListBox.DataSource = values;
            numNumbersLabel.Text = values.Count().ToString();
        }

        // Look for Armstrong numbers <= max.
        private List<long> FindArmstrongNumbers(long max)
        {
            List<long> values = new List<long>();
            for (long i = 1; i <= max; i++)
                if (IsArmstrong(i)) values.Add(i);
            return values;
        }

        // Return true if this is an Armstrong number.
        private bool IsArmstrong(long number)
        {
            // Get the number's digits.
            long copy = number;
            List<long> digits = new List<long>();
            while (copy > 0L)
            {
                digits.Add(copy % 10L);
                copy = copy / 10L;
            }

            // Add the digits' powers.
            long total = 0;
            long numDigits = digits.Count;
            foreach (long digit in digits)
                total += (long)Math.Pow(digit, numDigits);

            return (total == number);
        }
    }
}
