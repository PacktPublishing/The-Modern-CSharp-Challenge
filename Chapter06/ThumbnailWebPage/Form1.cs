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
using System.Drawing.Drawing2D;

namespace ThumbnailWebPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enable or disable the Create button.
        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            createButton.Enabled = (directoryTextBox.Text.Length > 0);
        }

        // Let the user select a directory.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = directoryTextBox.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        // Make the thumbnails.
        private void createButton_Click(object sender, EventArgs e)
        {
            numCreatedLabel.Text = "";
            Cursor = Cursors.WaitCursor;
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
            // Get the input parameters.
            string dirname = directoryTextBox.Text;
            int thumbWidth = int.Parse(widthTextBox.Text);
            int thumbHeight = int.Parse(heightTextBox.Text);

            // Graphic file name patterns.
            string[] patterns = { "*.png", "*.bmp", "*.jpg", "*.jpeg", "*.gif" };

            // Make a list of the directory's image files.
            List<string> filenames = new List<string>();
            foreach (string pattern in patterns)
                filenames.AddRange(Directory.GetFiles(dirname, pattern));

            // Compose the thumbnail directory's name.
            string thumbdir = Path.Combine(dirname, "Thumbnails");

            // Create an empty thumbnail directory.
            EmptyDirectory(thumbdir);
            Directory.CreateDirectory(thumbdir);

            // Start the web page.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<body>");

            // Process the files.
            foreach (string filename in filenames)
            {
                // Create the thumbnail.
                Bitmap bm = MakeThumbnail(filename, thumbWidth, thumbHeight);
                string thumbname = Path.Combine(thumbdir,
                    Path.GetFileNameWithoutExtension(filename)) +
                    " thumb.bmp";
                bm.Save(thumbname);

                // Add an entry to the web page.
                FileInfo fileinfo = new FileInfo(filename);
                string bigFilename = Path.Combine("..", fileinfo.Name);
                FileInfo thumbinfo = new FileInfo(thumbname);
                string thumbFilename = thumbinfo.Name;
                sb.AppendLine("  <a href=\"" + bigFilename + "\">" +
                    "<img src=\"" + thumbFilename + "\">" +
                    "</a>");
            }
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            // Write the web page.
            string webFilename = Path.Combine(thumbdir, "Thumbnails.html");
            File.WriteAllText(webFilename, sb.ToString());

            // Display the web page in the system's default browser.
            System.Diagnostics.Process.Start(webFilename);

            numCreatedLabel.Text = $"Created {filenames.Count} thumbnails";
        }

        // Make a thumbnail for the file with maximum dimensions maxWidth x maxHeight.
        private Bitmap MakeThumbnail(string filename, int maxWidth, int maxHeight)
        {
            // Load the image.
            Bitmap bm = LoadImageWithoutLocking(filename);

            // Calculate the scale.
            float xscale = maxWidth / (float)bm.Width;
            float yscale = maxHeight / (float)bm.Height;
            float scale = Math.Min(xscale, yscale);

            // Make the thumbnail's bitmap.
            int width = (int)Math.Round(bm.Width * scale);
            int height = (int)Math.Round(bm.Height * scale);
            Bitmap thumbnail = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(thumbnail))
            {
                gr.InterpolationMode = InterpolationMode.High;

                Rectangle srcRect = new Rectangle(0, 0, bm.Width, bm.Height);
                Point[] destPoints =
                {
                        new Point(0, 0),
                        new Point(width, 0),
                        new Point(0, height),
                    };
                gr.DrawImage(bm, destPoints, srcRect, GraphicsUnit.Pixel);
            }

            return thumbnail;
        }

        // Load an image file without locking it.
        private Bitmap LoadImageWithoutLocking(string filename)
        {
            using (Bitmap bm = new Bitmap(filename))
            {
                return new Bitmap(bm);
            }
        }

        // Delete the files in this directory.
        private void EmptyDirectory(string dirname)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(dirname);
            if (!dirinfo.Exists) return;

            foreach (FileInfo fileinfo in dirinfo.GetFiles()) fileinfo.Delete();
        }
    }
}
