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

namespace PrimalityTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Determine the probability that the number is prime.
        private void testButton_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(numberTextBox.Text);
            int numTests = int.Parse(numTestsTextBox.Text);
            probPrimeTextBox.Text = p.ProbabilityIsPrime(numTests).ToString();
        }
    }
}
