using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmicableNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display amicable numbers.
        private void goButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            numPairsLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            long max = long.Parse(maxTextBox.Text);
            List<List<long>> pairs = FindAmicablePairs(max);
            foreach (List<long> pair in pairs)
                resultListBox.Items.Add(pair[0] + ", " + pair[1]);

            numPairsLabel.Text = resultListBox.Items.Count.ToString();
            Cursor = Cursors.Default;
        }

        // Find amicable numbers <= max.
        private List<List<long>> FindAmicablePairs(long max)
        {
            // Get the array of sums.
            long[] sums = GetSumsOfDivisors(max);

            // Look for pairs.
            List<List<long>> pairs = new List<List<long>>();
            for (int value = 1; value <= max; value++)
            {
                long sum = sums[value];
                if ((sum > value) && (sum <= max) && (sums[sum] == value))
                {
                    List<long> pair = new List<long>();
                    pair.Add(value);
                    pair.Add(sums[value]);
                    pairs.Add(pair);
                }
            }

            return pairs;
        }

        // Calculate the sums of the divisors of numbers between 1 and max.
        private long[] GetSumsOfDivisors(long max)
        {
            // Make room for the sums.
            long[] sums = new long[max + 1];

            // Fill in the sums.
            for (long i = 1; i <= max; i++)
                sums[i] = GetProperDivisors(i).Sum();

            // Return the result.
            return sums;
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
    }
}
