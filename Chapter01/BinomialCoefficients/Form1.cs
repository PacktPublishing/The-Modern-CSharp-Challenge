using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinomialCoefficients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            calculatedTextBox.Clear();
            recursiveTextBox.Clear();
            cancelingTextBox.Clear();
            Refresh();

            // Get N and K.
            int n = int.Parse(nTextBox.Text);
            int k = int.Parse(kTextBox.Text);

            // Use the formula to find the binomial coefficient.
            try
            {
                calculatedTextBox.Text = CalculatedNchooseK(n, k).ToString();
            }
            catch (System.OverflowException ex)
            {
                calculatedTextBox.Text = ex.Message;
            }
            catch (Exception ex)
            {
                calculatedTextBox.Text = ex.Message;
            }
            Refresh();

            // Use recursion to find the binomial coefficient.
            if (n > 30)
                recursiveTextBox.Text = "N is too big";
            else
                try
                {
                    recursiveTextBox.Text = RecursiveNchooseK(n, k).ToString();
                }
                catch (Exception ex)
                {
                    recursiveTextBox.Text = ex.Message;
                }
            Refresh();

            // Use canceling to find the binomial coefficient.
            try
            {
                cancelingTextBox.Text = CancelingNchooseK(n, k).ToString();
            }
            catch (Exception ex)
            {
                cancelingTextBox.Text = ex.Message;
            }
        }

        // Calculate the factorial.
        // Note that checked blocks do not protect method calls
        // so this method needs a checked block, too.
        private long Factorial(int number)
        {
            checked
            {
                if (number <= 1) return 1;

                long total = 1;
                for (int i = 2; i <= number; i++) total *= i;
                return total;
            }
        }

        // Calculate the binomial coefficient.
        private long CalculatedNchooseK(int n, int k)
        {
            checked
            {
                return Factorial(n) / Factorial(k) / Factorial(n - k);
            }
        }

        // Use recursion to find the binomial coefficient.
        private long RecursiveNchooseK(int n, int k)
        {
            checked
            {
                if (k == 1) return n;
                if (k == n) return 1;

                return
                    RecursiveNchooseK(n - 1, k) +
                    RecursiveNchooseK(n - 1, k - 1);
            }
        }

        // Use canceling to find the binomial coefficient.
        private long CancelingNchooseK(int n, int k)
        {
            checked
            {
                long result = 1;
                for (int i = 1; i <= k; i++)
                {
                    result *= n - (k - i);
                    result /= i;
                }
                return result;
            }
        }
    }
}
