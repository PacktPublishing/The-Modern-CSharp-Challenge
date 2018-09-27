using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Generate pseudorandom ints.
        private void generateButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            resultListView.Items.Clear();
            Refresh();

            // Get parameters.
            int numValues = int.Parse(numValuesTextBox.Text);
            long minValue = long.Parse(minTextBox.Text);
            long maxValue = long.Parse(maxTextBox.Text);

            // Used to count the generated values.
            int[] counts = new int[maxValue - minValue];

            // Generate the values.
            for (int i = 0; i < numValues; i++)
            {
                long value = CryptoExtensions.NextLong(minValue, maxValue);
                // TEST: long value = CryptoExtensions.NextValue(minValue, maxValue);
                counts[value - minValue]++;
            }

            // Calculate the expected number and fraction of occurrences.
            double expectedOccurrences = numValues / (double)(maxValue - minValue);
            double expectedFraction = 1.0 / (maxValue - minValue);

            // Display the counts.
            for (int i = 0; i < maxValue - minValue; i++)
            {
                long value = minValue + i;
                ListViewItem item = resultListView.Items.Add($"{value}");

                item.SubItems.Add($"{counts[i]}");

                double fraction = counts[i] / (double)numValues;
                item.SubItems.Add($"{fraction:0.000000}");

                double error = fraction - expectedFraction;
                item.SubItems.Add($"{error:0.000000}");
            }

            Cursor = Cursors.Default;
        }
    }
}
