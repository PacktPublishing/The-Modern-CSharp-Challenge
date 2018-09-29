using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace ProperDivisors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display proper divisors.
        private void goButton_Click(object sender, EventArgs e)
        {
            method1TextBox.Clear();
            method2TextBox.Clear();
            method1TimeTextBox.Clear();
            method2TimeTextBox.Clear();
            numFactorsLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            long number = long.Parse(numberTextBox.Text);

            Stopwatch watch = new Stopwatch();

            watch.Start();
            List<long> factors1 = Method1(number);
            watch.Stop();
            method1TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            method1TextBox.Text = string.Join(" ",
                factors1.ConvertAll(i => i.ToString()));
            Refresh();

            watch.Restart();
            List<long> factors2 = GetProperDivisors(number);
            watch.Stop();
            method2TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            method2TextBox.Text = string.Join(" ",
                factors2.ConvertAll(i => i.ToString()));

            Debug.Assert(factors1.Count() == factors2.Count());

            numFactorsLabel.Text = factors1.Count().ToString();
            Cursor = Cursors.Default;
        }

        // Examine values between 1 and number / 2.
        private List<long> Method1(long number)
        {
            checked
            {
                List<long> divisors = new List<long>();

                long limit = number / 2;
                for (long factor = 1; factor <= limit; factor++)
                {
                    if (number % factor == 0)
                        divisors.Add(factor);
                }
                return divisors;
            }
        }

        // Examine values between 2 and Sqrt(number).
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
