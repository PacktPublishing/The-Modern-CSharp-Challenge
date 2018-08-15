using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace RemoveBlankLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Let the user pick a file.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = filenameTextBox.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filenameTextBox.Text = openFileDialog1.FileName;
        }

        // Process the selected file.
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numBlankLines, numNonBlankLines;
                RemoveBlankLines(filenameTextBox.Text, out numBlankLines, out numNonBlankLines);
                totalTextBox.Text = (numBlankLines + numNonBlankLines).ToString();
                blankTextBox.Text = numBlankLines.ToString();
                nonBlankTextBox.Text = numNonBlankLines.ToString();
            }
            catch (Exception ex)
            {
                totalTextBox.Clear();
                blankTextBox.Clear();
                nonBlankTextBox.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        // Remove the empty lines from the indicated file.
        private void RemoveBlankLines(string filename, out int numBlankLines, out int numNonBlankLines)
        {
            // Read the file.
            string[] lines = File.ReadAllLines(filename);
            int totalLines = lines.Length;

            // Remove blank lines.
            List<string> nonblankLines = new List<string>();
            foreach (string line in lines)
                if (line.Trim().Length > 0)
                    nonblankLines.Add(line);

            // Write the processed file.
            numNonBlankLines = nonblankLines.Count;
            numBlankLines = totalLines - numNonBlankLines;
            File.WriteAllLines(filename, nonblankLines.ToArray());
        }

        // Enable or disable the Go button.
        private void filenameTextBox_TextChanged(object sender, EventArgs e)
        {
            goButton.Enabled = (filenameTextBox.Text.Length > 0);
        }
    }
}
