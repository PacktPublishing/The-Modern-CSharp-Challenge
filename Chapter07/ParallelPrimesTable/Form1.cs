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

namespace ParallelPrimesTable
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
            Cursor = Cursors.WaitCursor;
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
            sb.Append("2 ");
            int count = 1;
            for (int i = 3; i < IsPrimeTable.Length; i += 2)
                if (IsPrimeTable[i])
                {
                    sb.Append(i + " ");
                    if (++count > 1000) break;
                }
            primesTextBox.Text = sb.ToString();

            //// Verify the results. (This is slow.)
            //for (int i = 2; i < max; i++)
            //{
            //    bool isPrime = IsPrime(i);
            //    Debug.Assert(BasicIsPrime[i] == isPrime);
            //    Debug.Assert(EratosthenesIsPrime[i] == isPrime);
            //    Debug.Assert(EulerIsPrime[i] == isPrime);
            //}

            Cursor = Cursors.Default;
        }

        // Use the IsPrime method to build a sieve.
        // Then find the largest prime <= max.
        private long IsPrimeMethod(int max)
        {
            // Use the IsPrime method to build a sieve.
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

        // Return true if the odd number is prime.
        private bool IsPrime(long number)
        {
            // Handle 2 separately.
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // See if the number is divisible by odd values up to Sqrt(number).
            long sqrt = (long)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
                if (number % i == 0) return false;

            // If we get here, the number is prime.
            return true;
        }

        // Use the IsPrime method to make a table of prime numbers.
        private int BasicMax;
        private bool[] BasicIsPrime;
        private bool[] MakePrimesTable(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            if (max % 2 == 0) max++;
            BasicIsPrime = new bool[max + 1];
            BasicIsPrime[2] = true;

            int start = 1;
            int stop = (int)(max / 2);
            Parallel.For(start, stop + 1, BasicCheck);

            return BasicIsPrime;
        }

        private void BasicCheck(int i)
        {
            i = 2 * i + 1;
            BasicIsPrime[i] = IsPrime(i);
        }

        // Make a sieve of Eratosthenes.
        private int EratosthenesMax;
        private bool[] EratosthenesIsPrime;
        private bool[] MakeSieveOfEratosthenes(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            if (max % 2 == 0) max++;
            EratosthenesMax = max;
            EratosthenesIsPrime = new bool[max + 1];
            EratosthenesIsPrime[2] = true;
            for (int i = 3; i <= max; i += 2) EratosthenesIsPrime[i] = true;
            
            // Cross out multiples of odd primes.
            int start = 1;
            int stop = (int)(max / 2);
            Parallel.For(start, stop + 1, EratosthenesCheck);

            return EratosthenesIsPrime;
        }

        private void EratosthenesCheck(int i)
        {
            i = 2 * i + 1;

            // See if i is prime.
            if (EratosthenesIsPrime[i])
            {
                // Knock out multiples of i.
                for (int j = i * 2; j <= EratosthenesMax; j += i)
                    EratosthenesIsPrime[j] = false;
            }
        }

        // Make Euler's sieve.
        private int EulerMax;
        private bool[] EulerIsPrime;
        private bool[] MakeEulersSieve(int max)
        {
            // Make the array and mark 2 and odd numbers greater than 1 as prime.
            if (max % 2 == 0) max++;
            EulerMax = max;
            EulerIsPrime = new bool[max + 1];
            EulerIsPrime[2] = true;
            for (int i = 3; i <= max; i += 2) EulerIsPrime[i] = true;
            
            // Cross out multiples of the primes.
            int start = 1;
            int stop = (int)(max / 2);
            Parallel.For(start, stop + 1, EulerCheck);

            return EulerIsPrime;
        }

        private void EulerCheck(int i)
        {
            i = 2 * i + 1;
            if (EulerIsPrime[i])
            {
                // Knock out multiples of p.
                int maxQ = EulerMax / i;
                if (maxQ % 2 == 0) maxQ--;    // Make it odd.
                for (int q = maxQ; q >= i; q -= 2)
                {
                    // Only use q if it is prime.
                    if (EulerIsPrime[q]) EulerIsPrime[i * q] = false;
                }
            }
        }
    }
}
