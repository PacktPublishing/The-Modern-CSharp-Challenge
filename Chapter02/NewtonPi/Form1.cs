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

namespace NewtonPi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate pi.
        private void goButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            errorTextBox.Clear();
            fractionTextBox.Clear();
            fractionErrorTextBox.Clear();
            Refresh();

            int numTerms = int.Parse(numTermsTextBox.Text);
            double pi = NewtonPi(numTerms);
            double error = pi - Math.PI;

            resultTextBox.Text = pi.ToString();
            errorTextBox.Text = error.ToString();

            double fraction = 355.0 / 113.0;
            fractionTextBox.Text = fraction.ToString();
            error = fraction - Math.PI;
            fractionErrorTextBox.Text = error.ToString(); 
        }

        // Use Newton's formula to calculate pi.
        private double NewtonPi(int numTerms)
        {
            double total = 0;
            for (int i = 0; i < numTerms; i++)
            {
                total +=
                    Factorial(2 * i) /
                    Math.Pow(2, 4 * i + 1) /
                    (Factorial(i) * Factorial(i)) /
                    (2 * i + 1);
                Debug.Assert(!double.IsInfinity(total));
            }

            double result = 6 * total;
            Debug.Assert(!double.IsInfinity(result));
            return result;
        }

        // Return number!
        private double Factorial(int number)
        {
            double total = 1;
            for (int i = 2; i <= number; i++) total *= i;
            return total;
        }
    }
}
