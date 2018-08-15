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

namespace DirectorySize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Let the user select a directory.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = directoryTextBox.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        // Enable or disable the Calculate button.
        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            bytesTextBox.Clear();
            fileSizeTextBox.Clear();
            calculateButton.Enabled = (directoryTextBox.Text.Length > 0);
        }
        private void includeSubdirsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bytesTextBox.Clear();
            fileSizeTextBox.Clear();
        }

        // Process the directory.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make a DirectoryInfo for the directory.
                DirectoryInfo dirinfo = new DirectoryInfo(directoryTextBox.Text);

                // Get the size.
                long size = dirinfo.Size(includeSubdirsCheckBox.Checked);

                // Display the size in bytes and file units.
                bytesTextBox.Text = size.ToString() + " bytes";
                fileSizeTextBox.Text = size.ToFileSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}