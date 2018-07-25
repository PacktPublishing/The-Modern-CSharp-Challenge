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

namespace PrimeFactors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const long MaxNumber = 1000000000000000;
        //private const long MaxNumber = 100000000000000000;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make the list of primes.
            Stopwatch watch = new Stopwatch();
            watch.Start();
            MakePrimeList(MaxNumber);
            watch.Stop();
            tableTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            method1TextBox.Clear();
            method2TextBox.Clear();
            method1TimeTextBox.Clear();
            method2TimeTextBox.Clear();
            Refresh();

            long number = long.Parse(numberTextBox.Text);
            if (number > MaxNumber)
            {
                MessageBox.Show("Number too big");
                return;
            }

            List<long> factors;
            Stopwatch watch = new Stopwatch();

            watch.Restart();
            factors = Method1(number);
            watch.Stop();
            method1TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            method1TextBox.Text = string.Join(" ",
                factors.ConvertAll(i => i.ToString()));
            Refresh();

            watch.Restart();
            factors = Method2(number);
            watch.Stop();
            method2TimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            method2TextBox.Text = string.Join(" ",
                factors.ConvertAll(i => i.ToString()));
            Refresh();
        }

        // Divide by smaller values up the the square root of the value.
        private List<long> Method1(long number)
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

        // Make a sieve of primes up to Sqrt(number).
        private List<long> Primes = new List<long>();
        private void MakePrimeList(long number)
        {
            checked
            {
                // Make a sieve of odd primes up to Sqrt(number).
                long max = (long)Math.Sqrt(number);
                bool[] isComposite = new bool[max + 1];
                for (int i = 3; i <= max; i += 2)
                {
                    // See if i is prime.
                    if (!isComposite[i])
                        // Knock out multiples of i.
                        for (int j = i * 2; j <= max; j += i)
                            isComposite[j] = true;
                }

                // Convert the sieve into a list of primes.
                Primes = new List<long>();
                Primes.Add(2);
                for (int i = 3; i <= max; i += 2)
                    if (!isComposite[i]) Primes.Add(i);
            }
        }

        // Use a pre-made sieve of primes up to MaxNumber.
        // Update the limit when we find a prime.
        private List<long> Method2(long number)
        {
            checked
            {
                List<long> factors = new List<long>();

                // Pull out primes.
                long limit = (long)Math.Sqrt(number);
                foreach (long prime in Primes)
                {
                    while (number % prime == 0)
                    {
                        factors.Add(prime);
                        number /= prime;
                        limit = (long)Math.Sqrt(number);
                    }
                    if (prime > limit) break;
                }

                // Add the leftover.
                if (number != 1) factors.Add(number);

                return factors;
            }
        }
    }
}
