using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticalFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Generate some random data.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Make the values.
            Random rand = new Random();
            int numValues = int.Parse(numValuesTextBox.Text);
            double discardFraction = double.Parse(discardFractionTextBox.Text);

            // Make an array of random values.
            int[] valuesArray = new int[numValues];
            for (int i = 0; i < numValues; i++)
                valuesArray[i] = rand.Next(1, 7) + rand.Next(1, 7);

            // Copy the array into a list.
            List<int> valuesList = new List<int>(valuesArray);

            // Display the values.
            valuesListBox.DataSource = valuesArray;

            // Display the values sorted.
            int[] sortedValues = new int[numValues];
            Array.Copy(valuesArray, sortedValues, numValues);
            Array.Sort(sortedValues);
            sortedValuesListBox.DataSource = sortedValues;

            // Display statistics for the array.
            arrayMinimumTextBox.Text = valuesArray.Min().ToString("0.00");
            arrayMaximumTextBox.Text = valuesArray.Max().ToString("0.00");
            arrayMeanTextBox.Text = valuesArray.Average().ToString("0.00");
            arrayTruncatedMeanTextBox.Text = valuesArray.TruncatedMean(0.1).ToString("0.00");
            arrayMedianTextBox.Text = valuesArray.Median().ToString("0.00");
            arrayModeTextBox.Text = string.Join(" ",
                valuesArray.Modes().ConvertAll(i => i.ToString()));
            arrayStddevSampleTextBox.Text = valuesArray.StdDev(true).ToString("0.00");
            arrayStddevPopulationTextBox.Text = valuesArray.StdDev(false).ToString("0.00");

            // Display statistics for the list.
            listMinimumTextBox.Text = valuesList.Min().ToString("0.00");
            listMaximumTextBox.Text = valuesList.Max().ToString("0.00");
            listMeanTextBox.Text = valuesList.Average().ToString("0.00");
            listTruncatedMeanTextBox.Text = valuesArray.TruncatedMean(discardFraction).ToString("0.00");
            listMedianTextBox.Text = valuesList.Median().ToString("0.00");
            listModeTextBox.Text = string.Join(" ",
                valuesList.Modes().ConvertAll(i => i.ToString()));
            listStddevSampleTextBox.Text = valuesList.StdDev(true).ToString("0.00");
            listStddevPopulationTextBox.Text = valuesList.StdDev(false).ToString("0.00");

            // Make a simple histogram.
            Label[] labels = { lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12 };

            // Count the values.
            int[] counts = new int[13];
            for (int i = 0; i < numValues; i++) counts[valuesList[i]]++;

            // Scale the bars.
            int bottom = lbl2.Bottom;
            float scale = (lbl2.Bottom - numValuesTextBox.Top) / (float)counts.Max();
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Height = (int)(counts[i + 2] * scale);
                labels[i].Top = bottom - labels[i].Height;
            }
        }
    }
}
