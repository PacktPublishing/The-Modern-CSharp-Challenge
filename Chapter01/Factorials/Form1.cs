using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate and display the factorial.
        private void goButton_Click(object sender, EventArgs e)
        {
            long number = long.Parse(numberTextBox.Text);
            recursiveTextBox.Text = RecursiveFactorial(number).ToString();
            nonRecursiveTextBox.Text = NonRecursiveFactorial(number).ToString();
        }

        // Calculate the factorial recursively.
        private long RecursiveFactorial(long number)
        {
            checked
            {
                if (number <= 1) return 1;
                return number * RecursiveFactorial(number - 1);
            }
        }

        // Calculate the factorial non-recursively.
        private long NonRecursiveFactorial(long number)
        {
            checked
            {
                long total = 1;
                for (int i = 2; i <= number; i++) total *= i;
                return total;
            }
        }
    }
}
