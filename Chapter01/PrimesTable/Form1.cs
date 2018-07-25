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

namespace PrimesTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A saved sieve.
        private bool[] IsPrimeTable;

        // Demonstrate the sieve of Eratosthenes and Euler's sieve.
        private void goButton_Click(object sender, EventArgs e)
        {
            isPrimeTextBox.Clear();
            eratosthenesTextBox.Clear();
            eulerTextBox.Clear();
            isPrimeTimeTextBox.Clear();
            eratosthenesTimeTextBox.Clear();
            eulerTimeTextBox.Clear();
            primesTextBox.Clear();
            Refresh();

            int max = int.Parse(maxTextBox.Text);

            Stopwatch watch = new Stopwatch();

            watch.Restart();
            isPrimeTextBox.Text = IsPrimeMethod(max).ToString();
            watch.Stop();
            isPrimeTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            watch.Restart();
            eratosthenesTextBox.Text = EratosthenesMethod(max).ToString();
            watch.Stop();
            eratosthenesTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            watch.Restart();
            eulerTextBox.Text = EulerMethod(max).ToString();
            watch.Stop();
            eulerTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");

            // Display the primes in the sieve.
            StringBuilder sb = new StringBuilder();
            int upperLimit = Math.Min(10000, IsPrimeTable.Length);
            for (int i = 2; i <= upperLimit; i++)
                if (IsPrimeTable[i]) sb.Append(i + " ");
            primesTextBox.Text = sb.ToString();
        }

        // Use the IsPrime method to build a sieve.
        // Then find the largest prime <= max.
        private long IsPrimeMethod(int max)
        {
            // Make a sieve of Eratosthenes.
            bool[] isPrime = MakePrimesTable(max);

            // Use the sieve.
            for (long i = max; i > 0; i--) if (isPrime[i]) return i;
            return -1;
        }

        // Use a sieve of Eratosthenes to find the largest prime <= max.
        private long EratosthenesMethod(int max)
        {
            // Make a sieve of Eratosthenes.
            bool[] isPrime = MakeSieveOfEratosthenes(max);

            // Use the sieve.
            for (long i = max; i > 0; i--) if (isPrime[i]) return i;
            return -1;
        }

        // Use Euler's sieve to find the largest prime <= max.
        private long EulerMethod(int max)
        {
            // Make and save Euler's sieve.
            IsPrimeTable = MakeEulersSieve(max);

            // Use the sieve.
            for (long i = max; i > 0; i--) if (IsPrimeTable[i]) return i;
            return -1;
        }

        // Return true if the number is prime.
        private bool IsPrime(long number)
        {
            // Handle 2 separately.
            if (number == 2) return true;

            // See if the number is divisible by odd values up to Sqrt(number).
            long sqrt = (long)Math.Sqrt(number);
            for (int i = 3; i < sqrt; i += 2)
                if (number % i == 0) return false;

            // If we get here, the number is prime.
            return true;
        }

        // Use the IsPrime method to make a table of prime numbers.
        private bool[] MakePrimesTable(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            bool[] isPrime = new bool[max + 1];
            isPrime[2] = true;
            for (int i = 3; i <= max; i += 2) isPrime[i] = IsPrime(i);
            return isPrime;
        }

        // Make a sieve of Eratosthenes.
        private bool[] MakeSieveOfEratosthenes(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            bool[] isPrime = new bool[max + 1];
            isPrime[2] = true;
            for (int i = 3; i <= max; i += 2) isPrime[i] = true;

            // Cross out multiples of odd primes.
            for (int i = 3; i <= max; i++)
            {
                // See if i is prime.
                if (isPrime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        isPrime[j] = false;
                }
            }
            return isPrime;
        }

        // Make Euler's sieve.
        private bool[] MakeEulersSieve(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            bool[] isPrime = new bool[max + 1];
            isPrime[2] = true;
            for (int i = 3; i <= max; i += 2) isPrime[i] = true;

            // Cross out multiples of the primes.
            for (int i = 3; i <= max; i += 2)
            {
                // See if i is prime.
                if (isPrime[i])
                {
                    // Knock out multiples of p.
                    int maxQ = max / i;
                    if (maxQ % 2 == 0) maxQ--;    // Make it odd.
                    for (int q = maxQ; q >= i; q -= 2)
                    {
                        // Only use q if it is prime.
                        if (isPrime[q]) isPrime[i * q] = false;
                    }
                }
            }
            return isPrime;
        }
    }
}
