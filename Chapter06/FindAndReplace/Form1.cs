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

namespace FindAndReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Select a file on single click.
        private void Form1_Load(object sender, EventArgs e)
        {
            filesCheckedListBox.CheckOnClick = true;
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
            filesCheckedListBox.DataSource = null;
            findButton.Enabled = (
                (directoryTextBox.Text.Length > 0) &&
                (patternsComboBox.Text.Length > 0));
        }

        // Search the directory.
        private void findButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            filesCheckedListBox.DataSource = null;
            Refresh();

            // Get the patterns.
            string patternsString = patternsComboBox.Text;
            if (patternsString.Contains(':'))
                patternsString =
                    patternsString.Substring(patternsString.IndexOf(':') + 1).Trim();
            string[] patterns = patternsString.Trim().Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            // Find files matching the patterns and containing the target text.
            DirectoryInfo dirinfo = new DirectoryInfo(directoryTextBox.Text);
            FileInfo[] fileinfos = dirinfo.FindFiles(patterns,
                targetTextBox.Text, SearchOption.AllDirectories);

            // List the files.
            filesCheckedListBox.DataSource = fileinfos;

            Cursor = Cursors.Default;
        }

        // Replace the target text with the replacement text in the selected files.
        private void replaceButton_Click(object sender, EventArgs e)
        {
            string changeFrom = targetTextBox.Text;
            string changeTo = replaceWithTextBox.Text;
            int numReplacements = 0;
            foreach (FileInfo fileinfo in filesCheckedListBox.CheckedItems)
            {
                MakeReplacement(fileinfo, changeFrom, changeTo);
                numReplacements++;
            }
            MessageBox.Show("Made replacements in " + numReplacements.ToString() + " files.");

            // Clear the file list.
            filesCheckedListBox.DataSource = null;
        }

        // Enable or disable the Replace button.
        private void filesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            replaceButton.Enabled = (filesCheckedListBox.CheckedItems.Count > 0);
        }

        // Replace changeFrom to changedTo in the file.
        private void MakeReplacement(FileInfo fileinfo, string changeFrom, string changeTo)
        {
            string file = File.ReadAllText(fileinfo.FullName);
            file = file.Replace(changeFrom, changeTo);
            File.WriteAllText(fileinfo.FullName, file);
        }
    }
}
