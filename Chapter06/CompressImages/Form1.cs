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

namespace CompressImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The name of the temporary file.
        private static string tempfile = "__temp.jpg";

        // The original image.
        private Image OriginalImage = null;

        // Let the user load an image file.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    ProcessFile(LoadImageWithoutLocking(openFileDialog1.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        // Load an image file without locking it.
        private Bitmap LoadImageWithoutLocking(string filename)
        {
            using (Bitmap bm = new Bitmap(filename))
            {
                return new Bitmap(bm);
            }
        }

        // Save the file atthe current compression level.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    compressedPictureBox.Image.SaveCompressed(
                        saveFileDialog1.FileName, compressionScrollbar.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Display the selected compression level and file size.
        private void compressionScrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            ProcessFile(OriginalImage);
        }

        // Process a newly loaded file.
        private void ProcessFile(Image image)
        {
            if (image == null) return;

            // Save the original image.
            OriginalImage = image;

            // Save the image in a temporary file with the current compression level.
            image.SaveCompressed(tempfile, compressionScrollbar.Value);

            // Reload the file.
            compressedPictureBox.Image = LoadImageWithoutLocking(tempfile);

            // Display the file compression level.
            compressionLabel.Text = compressionScrollbar.Value.ToString();

            // Display the file's size.
            FileInfo fileinfo = new FileInfo(tempfile);
            fileSizeLabel.Text = fileinfo.Length.ToFileSize();
        }

        // Delete the temporary file.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(tempfile)) File.Delete(tempfile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
