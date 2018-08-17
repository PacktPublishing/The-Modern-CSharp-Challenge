using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YieldingPrimes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display primes.
        private void goButton_Click(object sender, EventArgs e)
        {
            primesListBox.Items.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            int numPrimes = int.Parse(numPrimesTextBox.Text);
            int i = 1;
            foreach (long prime in Primes(numPrimes))
                primesListBox.Items.Add(i++.ToString() + ": " + prime);

            Cursor = Cursors.Default;
        }

        // Yield numPrimes primes.
        private IEnumerable<long> Primes(int numPrimes)
        {
            // Treat 2 separately.
            yield return 2;
            if (numPrimes == 1) yield break;

            int count = 1;
            for (long i = 3; ; i += 2)
            {
                if (IsPrime(i))
                {
                    yield return i;
                    if (++count == numPrimes) yield break;
                }
            }
        }

        // Return true if the number is prime.
        private bool IsPrime(long number)
        {
            // Handle 2 separately.
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // See if the number is divisible by odd values up to Sqrt(number).
            long sqrt = (long)Math.Sqrt(number);
            for (long i = 3; i <= sqrt; i += 2)
                if (number % i == 0) return false;

            // If we get here, the number is prime.
            return true;
        }
    }
}
