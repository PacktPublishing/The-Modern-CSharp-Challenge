using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YieldingFibonacciNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display Fibonacci numbers.
        private void goButton_Click(object sender, EventArgs e)
        {
            fiboListBox.Items.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            int i = 1;
            foreach (long fiboNumber in FibonacciNumbers())
                fiboListBox.Items.Add(i++.ToString() + ": " + fiboNumber);

            Cursor = Cursors.Default;
        }

        // Yield Fibonacci numbers.
        private IEnumerable<long> FibonacciNumbers()
        {
            // Treat 0 and 1 separately.
            yield return 0;
            yield return 1;

            // Calculate other values.
            long fiboIMinus2 = 0;
            long fiboIMinus1 = 1;
            long fiboI = 0;
            for (;;)
            {
                try
                {
                    fiboI = checked(fiboIMinus2 + fiboIMinus1);
                }
                catch
                {
                    yield break;
                }

                fiboIMinus2 = fiboIMinus1;
                fiboIMinus1 = fiboI;
                yield return fiboI;
            }
        }
    }
}
