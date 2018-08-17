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
using System.Diagnostics;

namespace DirectorySizePLINQ
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
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            bytesTextBox.Clear();
            fileSizeTextBox.Clear();
            foreachTimeTextBox.Clear();
            linqTimeTextBox.Clear();
            plinqTimeTextBox.Clear();
            calculateButton.Enabled = (directoryTextBox.Text.Length > 0);
        }
        private void includeSubdirsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bytesTextBox.Clear();
            fileSizeTextBox.Clear();
            foreachTimeTextBox.Clear();
            linqTimeTextBox.Clear();
            plinqTimeTextBox.Clear();
        }

        // Process the directory.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            bytesTextBox.Clear();
            fileSizeTextBox.Clear();
            foreachTimeTextBox.Clear();
            linqTimeTextBox.Clear();
            plinqTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            try
            {
                int numTrials = int.Parse(numTrialsTextBox.Text);

                // Make a DirectoryInfo for the directory.
                DirectoryInfo dirinfo = new DirectoryInfo(directoryTextBox.Text);

                // Get the size.
                long size = 0;
                Stopwatch watch = new Stopwatch();

                watch.Start();
                for (int trial = 0; trial < numTrials; trial++)
                    size = dirinfo.Size(includeSubdirsCheckBox.Checked);
                watch.Stop();
                foreachTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
                foreachTimeTextBox.Refresh();

                watch.Restart();
                for (int trial = 0; trial < numTrials; trial++)
                    size = dirinfo.SizeLINQ(includeSubdirsCheckBox.Checked);
                watch.Stop();
                linqTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
                linqTimeTextBox.Refresh();

                watch.Restart();
                for (int trial = 0; trial < numTrials; trial++)
                    size = dirinfo.SizePLINQ(includeSubdirsCheckBox.Checked);
                watch.Stop();
                plinqTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
                plinqTimeTextBox.Refresh();

                // Display the size in bytes and file units.
                bytesTextBox.Text = size.ToString();
                fileSizeTextBox.Text = size.ToFileSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor = Cursors.Default;
        }
    }
}