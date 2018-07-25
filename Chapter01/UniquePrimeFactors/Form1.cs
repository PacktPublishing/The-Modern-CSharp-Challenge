using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniquePrimeFactors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            factorsTextBox.Clear();
            uniqueFactorsTextBox.Clear();
            Refresh();

            long number = long.Parse(txtNumber.Text);
            List<long> factors;

            factors = FindPrimeFactors(number);
            factorsTextBox.Text = string.Join(" ",
                factors.ConvertAll(i => i.ToString()));
            Refresh();

            factors = FindUniquePrimeFactors(number);
            uniqueFactorsTextBox.Text = string.Join(" ",
                factors.ConvertAll(i => i.ToString()));
            Refresh();

        }

        // Divide by smaller values up the the square root of the value.
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

        // Find a number's unique prime factors.
        private List<long> FindUniquePrimeFactors(long number)
        {
            checked
            {
                List<long> factors = new List<long>();

                // Pull out 2s.
                if (number % 2 == 0)
                {
                    factors.Add(2);
                    while (number % 2 == 0) number /= 2;
                }

                // Pull out odd factors.
                long limit = (long)Math.Sqrt(number);
                for (long factor = 3; factor <= limit; factor += 2)
                {
                    if (number % factor == 0)
                    {
                        factors.Add(factor);
                        while (number % factor == 0)
                        {
                            number /= factor;
                            limit = (long)Math.Sqrt(number);
                        }
                    }
                }

                // Add the leftover.
                if (number != 1) factors.Add(number);

                return factors;
            }
        }
    }
}
