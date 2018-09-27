using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The original image.
        private Bitmap OriginalImage = null;

        // True if the user has encoded a message but not saved it.
        private bool HasUnsavedChanges = false;

        // Open an image file.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OriginalImage =
                        LoadImageWithoutLocking(openFileDialog1.FileName);
                    imagePictureBox.Image = OriginalImage;

                    imagePictureBox.Visible = true;
                    encodeToolStripMenuItem.Enabled = true;
                    decodeToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Save the modified image.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageAs();
        }
        private void SaveImageAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagePictureBox.Image.SaveImage(saveFileDialog1.FileName);
                    HasUnsavedChanges = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Hide the message in the picture.
        private void encodeButton_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Load an image file without locking it.
        private Bitmap LoadImageWithoutLocking(string filename)
        {
            using (Bitmap bm = new Bitmap(filename))
            {
                return new Bitmap(bm);
            }
        }

        // Encode the message.
        private void encodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                imagePictureBox.Image = OriginalImage.StegMessage(messageTextBox.Text);
                HasUnsavedChanges = true;
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Recover the hidden message.
        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = imagePictureBox.Image as Bitmap;
            messageTextBox.Text = bm.DestegMessage();
        }

        // If the user has not saved the encoded image, confirm.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasUnsavedChanges)
            {
                DialogResult result = MessageBox.Show(
                    "You have not saved the encoded image. " +
                    "Do you want to save the changes?",
                    "Save Changes?",
                    MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.No) return;  // Exit without saving.

                if (result == DialogResult.Cancel)      // Do not exit.
                {
                    e.Cancel = true;
                    return;
                }

                // Else try to save changes and cancel if we fail.
                SaveImageAs();
                e.Cancel = HasUnsavedChanges;
            }
        }
    }
}
