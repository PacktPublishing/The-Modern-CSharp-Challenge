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

namespace FindFiles
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

        // Clear previous results and enable or disable the Search button.
        private void input_TextChanged(object sender, EventArgs e)
        {
            filesListBox.DataSource = null;
            findButton.Enabled = (
                (directoryTextBox.Text.Length > 0) &&
                (patternsComboBox.Text.Length > 0));
        }

        // Search the directory.
        private void findButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            filesListBox.DataSource = null;
            Refresh();

            // Get the patterns.
            string patternsString = patternsComboBox.Text;
            if (patternsString.Contains(':'))
                patternsString =
                    patternsString.Substring(patternsString.IndexOf(':') + 1).Trim();
            string[] patterns = patternsString.Trim().Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < patterns.Length; i++) patterns[i] = patterns[i].Trim();

            // Find files matching the patterns and containing the target text.
            DirectoryInfo dirinfo = new DirectoryInfo(directoryTextBox.Text);
            FileInfo[] fileinfos = dirinfo.FindFiles(patterns,
                targetTextBox.Text, SearchOption.AllDirectories);

            // List the files.
            filesListBox.DataSource = fileinfos;

            Cursor = Cursors.Default;
        }
    }
}
