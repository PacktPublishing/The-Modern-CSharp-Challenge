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

namespace SumsOfMultiples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add and display the sums of multiples of three and five.
        private void btnGo_Click(object sender, EventArgs e)
        {
            method1TextBox.Clear();
            method2TextBox.Clear();
            method3TextBox.Clear();
            method4TextBox.Clear();
            method1TimeTextBox.Clear();
            method2TimeTextBox.Clear();
            method3TimeTextBox.Clear();
            method4TimeTextBox.Clear();
            Refresh();

            long max = long.Parse(txtMax.Text);
            long total;
            Stopwatch watch = new Stopwatch();

            watch.Restart();
            if (max > 1000000000)
                method1TextBox.Text = "Max too big";
            else
            {
                total = Method1(max);
                watch.Stop();
                method1TextBox.Text = total.ToString();
            }
            method1TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            try
            {
                watch.Restart();
                total = Method2(max);
                watch.Stop();
                method2TextBox.Text = total.ToString();
            }
            catch (Exception ex)
            {
                method2TextBox.Text = ex.Message;
            }
            method2TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            try
            {
                watch.Restart();
                total = Method3(max);
                watch.Stop();
                method3TextBox.Text = total.ToString();
            }
            catch (Exception ex)
            {
                method3TextBox.Text = ex.Message;
            }
            method3TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            try
            {
                watch.Restart();
                total = Method4(max);
                watch.Stop();
                method4TextBox.Text = total.ToString();
            }
            catch (Exception ex)
            {
                method4TextBox.Text = ex.Message;
            }
            method4TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
        }

        // Examine all numbers between 3 and max and
        // see which are multiples of 3 or 5.
        private long Method1(long max)
        {
            long total = 0;
            checked
            {
                for (long i = 3; i <= max; i++)
                    if ((i % 3 == 0) || (i % 5 == 0))
                        total += i;
            }
            return total;
        }

        // Examine multiples of 3 between 3 and max
        // keeping track of the next multiple of 5.
        private long Method2(long max)
        {
            long total = 0;
            checked
            {
                int next5 = 5;
                for (long i = 3; i <= max; i += 3)
                {
                    total += i;
                    if (i == next5)
                    {
                        next5 += 5;
                    }
                    else if (i > next5)
                    {
                        total += next5;
                        next5 += 5;
                    }
                }

                // Check the final few entries.
                for (long i = max; i > max - 3; i--)
                {
                    if (i % 3 == 0) break;
                    if (i % 5 == 0)
                    {
                        total += i;
                        break;
                    }
                }
            }
            return total;
        }

        // Add multiples of 3 and 5, then subtract multiples of 15.
        private long Method3(long max)
        {
            checked
            {
                long total = 0;
                for (long i = 3; i <= max; i += 3) total += i;
                for (long i = 15; i <= max; i += 15) total -= i;
                for (long i = 5; i <= max; i += 5) total += i;
                return total;
            }
        }

        // Calculate the sums of 3s, 5s, and 15s.
        private long Method4(long max)
        {
            checked
            {
                long num3s = max / 3;
                long threes = num3s * (num3s + 1) / 2 * 3;
                long num5s = max / 5;
                long fives = num5s * (num5s + 1) / 2 * 5;
                long num15s = max / 15;
                long fifteens = num15s * (num15s + 1) / 2 * 15;

                return threes - fifteens + fives;
            }
        }
    }
}
