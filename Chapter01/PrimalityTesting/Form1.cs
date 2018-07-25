using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimalityTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // See if the number is prime.
        private void goButton_Click(object sender, EventArgs e)
        {
            long number = long.Parse(numberTextBox.Text);
            if (IsPrime(number))
                isPrimeLabel.Text = "Is prime";
            else
                isPrimeLabel.Text = "Is composite";
        }

        // Return true if the number is prime.
        private bool IsPrime(long number)
        {
            // Handle 2 separately.
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // See if the number is divisible by odd values up to Sqrt(number).
            long sqrt = (long)Math.Sqrt(number);
            for (long i = 3; i < sqrt; i += 2)
                if (number % i == 0) return false;

            // If we get here, the number is prime.
            return true;
        }
    }
}
