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

namespace FindDuplicateFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enable or disable the Go button.
        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            filesTreeView.Nodes.Clear();
            goButton.Enabled = (directoryTextBox.Text.Length > 0);
        }

        // Let the user select a directory.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = directoryTextBox.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        // Look for duplicate files.
        private void goButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            filesTreeView.Nodes.Clear();
            Refresh();

            try
            {
                ProcessFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor = Cursors.Default;
        }

        // Process the files.
        private void ProcessFiles()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(directoryTextBox.Text);
            List<List<FileInfo>> groups = dirinfo.GetIdenticalFiles();

            if (groups.Count == 0)
                filesTreeView.Nodes.Add("No identical files");
            else
            {
                char label = 'A';
                foreach (List<FileInfo> group in groups)
                {
                    // Create a branch for this group.
                    TreeNode branch = filesTreeView.Nodes.Add(label++.ToString());

                    // Add the files.
                    foreach (FileInfo fileinfo in group)
                    {
                        // Display the file's name.
                        TreeNode node = branch.Nodes.Add(fileinfo.Name);

                        // Save the FileInfo in case we want it later.
                        node.Tag = fileinfo;
                    }
                }
                filesTreeView.ExpandAll();
            }
        }
    }
}
