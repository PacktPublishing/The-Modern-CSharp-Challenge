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

        // MODIFICATION MODIFICATION MODIFICATION XX.
        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            filesTreeView.Nodes.Clear();
            goButton.Enabled = (directoryTextBox.Text.Length > 0);
        }

        // Let the user select a directory.
        private void selectDirectoryButton_Click(object sender, EventArgs e)
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

            string dirname = directoryTextBox.Text;
            List<List<FileInfo>> groups = GetSameSizedFiles(dirname);

            if (groups.Count == 0)
                filesTreeView.Nodes.Add("No matching file sizes");
            else
            {
                foreach (List<FileInfo> group in groups)
                {
                    TreeNode branch = filesTreeView.Nodes.Add(group[0].Length.ToFileSize());
                    foreach (FileInfo fileinfo in group)
                    {
                        branch.Nodes.Add(fileinfo.Name);
                    }
                }
                filesTreeView.ExpandAll();
            }

            Cursor = Cursors.Default;
        }

        // Return lists of files with the same sizes.
        private List<List<FileInfo>> GetSameSizedFiles(string dirname)
        {
            // Get the directory's files.
            DirectoryInfo dirinfo = new DirectoryInfo(dirname);
            FileInfo[] fileinfos = dirinfo.GetFiles();
            long[] filesizes = new long[fileinfos.Length];

            // Get the file sizes.
            for (int i = 0; i < fileinfos.Length; i++)
                filesizes[i] = fileinfos[i].Length;

            // Sort by file size.
            Array.Sort(filesizes, fileinfos);

            // Find groups of files with the same sizes.
            List<List<FileInfo>> groups = new List<List<FileInfo>>();
            int num = 1;
            while (num < fileinfos.Length)
            {
                if (fileinfos[num].Length == fileinfos[num - 1].Length)
                {
                    // We have a match. Make a list of files with this size.
                    List<FileInfo> files = new List<FileInfo>();
                    groups.Add(files);
                    files.Add(fileinfos[num - 1]);
                    long length = fileinfos[num - 1].Length;
                    while ((num < fileinfos.Length) && (fileinfos[num].Length == length))
                    {
                        files.Add(fileinfos[num++]);
                    }
                }
                else
                    num++;
            }

            return groups;
        }
    }
}
