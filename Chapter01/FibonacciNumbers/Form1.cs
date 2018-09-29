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

// Note: Fibonacci(93) causes overflow.

namespace FibonacciNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Clear previous results.
            Cursor = Cursors.WaitCursor;
            recursiveTextBox.Clear();
            nonRecursiveTextBox.Clear();
            tableTextBox.Clear();
            cacheTextBox.Clear();
            recursiveTimeTextBox.Clear();
            nonRecursiveTimeTextBox.Clear();
            tableTimeTextBox.Clear();
            cacheTimeTextBox.Clear();
            Refresh();

            // Get the number.
            int number = int.Parse(numberTextBox.Text);

            // Calculate the Fibonacci number recursively.
            Stopwatch watch = new Stopwatch();
            if (number <= 45)
            {
                watch.Restart();
                recursiveTextBox.Text = RecursiveFibonacci(number).ToString();
                watch.Stop();
                recursiveTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");
                Refresh();
            }

            // Calculate the Fibonacci number non-recursively.
            watch.Restart();
            nonRecursiveTextBox.Text = NonRecursiveFibonacci(number).ToString();
            watch.Stop();
            nonRecursiveTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");

            // Use a table to calculate the Fibonacci number non-recursively.
            watch.Restart();
            tableTextBox.Text = TableFibonacci(number).ToString();
            watch.Stop();
            tableTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");

            // Use a cache to calculate the Fibonacci number.
            watch.Restart();
            cacheTextBox.Text = CachedFibonacci(number).ToString();
            watch.Stop();
            cacheTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");

            Cursor = Cursors.Default;
        }

        // Calculate the Fibonacci number recursively.
        private long RecursiveFibonacci(int number)
        {
            checked
            {
                // On 0 or 1, return 0 or 1.
                if (number <= 1) return number;

                // Fibonacci(N) = Fibonacci(N - 1) + Fibonacci(N - 2).
                return
                    RecursiveFibonacci(number - 1) +
                    RecursiveFibonacci(number - 2);
            }
        }

        // Calculate the Fibonacci number non-recursively.
        private long NonRecursiveFibonacci(int number)
        {
            checked
            {
                // On 0 or 1, return 0 or 1.
                if (number <= 1) return number;

                // Start at i = 2.
                long fiboIMinus2 = 0;                   // Fibonacci(0)
                long fiboIMinus1 = 1;                   // Fibonacci(1)
                long fiboI = fiboIMinus1 + fiboIMinus2; // Fibonacci(2)

                for (int i = 2; i < number; i++)
                {
                    // Update the values.
                    fiboIMinus2 = fiboIMinus1;
                    fiboIMinus1 = fiboI;
                    fiboI = fiboIMinus1 + fiboIMinus2;
                }

                return fiboI;
            }
        }

        // Use a table to calculate the Fibonacci number non-recursively.
        private long TableFibonacci(int number)
        {
            checked
            {
                // Make a table to hold Fibonacci values.
                long[] values = new long[number + 1];

                // Initialize Fibonacci(0) and Fibonacci(1).
                values[0] = 0;
                values[1] = 1;

                // Fill the table.
                for (int i = 2; i <= number; i++)
                    values[i] = values[i - 1] + values[i - 2];

                // Return values[number].
                return values[number];
            }
        }

        // Use a cache table to calculate the Fibonacci number non-recursively.
        private long[] FibonacciCache = null;
        private long CachedFibonacci(int number)
        {
            // Initialize the cache if necessary.
            if (FibonacciCache == null)
            {
                // Initialize the table to hold all -1 entries.
                // Fibonacci(92) is the largest value that doesn't overflow.
                const int MaxNumber = 92;
                FibonacciCache = Enumerable.Repeat(-1L, MaxNumber + 1).ToArray();

                // Initialize Fibonacci(0) and Fibonacci(1).
                FibonacciCache[0] = 0;
                FibonacciCache[1] = 1;
            }

            // Use the cache to calculate the Fibonacci number.
            checked
            {
                // We don't have the value. Calculate and save it.
                if (FibonacciCache[number] < 0)
                    FibonacciCache[number] =
                        CachedFibonacci(number - 1) +
                        CachedFibonacci(number - 2);

                // Return the cached value.
                return FibonacciCache[number];
            }
        }
    }
}
