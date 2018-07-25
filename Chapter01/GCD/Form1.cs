using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Find and display the GCD.
        private void goButton_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTextBox.Text);
            long b = long.Parse(bTextBox.Text);
            gcdTextBox.Text = GCD(a, b).ToString();
        }

        // Use Euclid's algorithm to find GCD(a, b).
        private long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Pull out remainders.
            for (;;)
            {
                long remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }
    }
}
