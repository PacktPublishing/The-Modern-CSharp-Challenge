using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// First perfect numbers:
//              6
//             28
//            496
//          8,128
//     33,550,336
//  8,589,869,056
namespace PerfectNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Find perfect numbers.
        private void goButton_Click(object sender, EventArgs e)
        {
            resultListBox.DataSource = null;
            numNumbersLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            long max = long.Parse(maxTextBox.Text);
            List<long> values = FindPerfectNumbers(max);
            resultListBox.DataSource = values;

            numNumbersLabel.Text = resultListBox.Items.Count.ToString();
            Cursor = Cursors.Default;
        }

        // Find perfect numbers <= max.
        private List<long> FindPerfectNumbers(long max)
        {
            // Look for perfect numbers.
            List<long> values = new List<long>();
            for (int value = 1; value <= max; value++)
            {
                long sum = GetProperDivisors(value).Sum();
                if (value == sum) values.Add(value);
            }

            return values;
        }

        // Return this number's proper divisors.
        private List<long> GetProperDivisors(long number)
        {
            checked
            {
                List<long> divisors = new List<long>();
                divisors.Add(1);

                long limit = (long)Math.Sqrt(number);
                for (long divisor = 2; divisor <= limit; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        divisors.Add(divisor);

                        long divisor2 = number / divisor;
                        if (divisor != divisor2) divisors.Add(divisor2);
                    }
                }
                divisors.Sort();
                return divisors;
            }
        }

        // Find the number's prime factors.
        private List<long> FindPrimeFactors(long number)
        {
            checked
            {
                List<long> factors = new List<long>();

                // Pull out 2s.
                while (number % 2 == 0)
                {
                    factors.Add(2);
                    number /= 2;
                }

                // Pull out odd factors.
                long limit = (long)Math.Sqrt(number);
                for (long factor = 3; factor <= limit; factor += 2)
                {
                    while (number % factor == 0)
                    {
                        factors.Add(factor);
                        number /= factor;
                        limit = (long)Math.Sqrt(number);
                    }
                }

                // Add the leftover.
                if (number != 1) factors.Add(number);

                return factors;
            }
        }
    }
}
