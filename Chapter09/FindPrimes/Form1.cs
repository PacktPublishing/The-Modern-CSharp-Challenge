using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add a reference to System.Numerics.
using System.Numerics;

namespace FindPrimes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Used to pick random N.
        private Random Rand = new Random();

        // Find a prime at least as big as the value the user entered.
        private void findButton_Click(object sender, EventArgs e)
        {
            BigInteger startNumber = BigInteger.Parse(startTextBox.Text);
            double desiredProb = double.Parse(desiredProbTextBox.Text);

            // Find a prime.
            double primeProb;
            int numTests;
            BigInteger p = startNumber.FindNextPrime(desiredProb, out primeProb, out numTests);

            primeTextBox.Text = p.ToString();
            numTestsTextBox.Text = numTests.ToString();
            probPrimeTextBox.Text = primeProb.ToString();
        }
    }
}
