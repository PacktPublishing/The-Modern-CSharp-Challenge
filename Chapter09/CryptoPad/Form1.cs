using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The previously loaded file's name.
        private string Filename = null;

        // Return true if the data is safe.
        // If it is not safe, attempt to save it if desired.
        private bool DataIsSafe()
        {
            // If there are no unsaved changes, it's safe to exit.
            if (!textRtb.Modified) return true;

            // Ask the user is we should save the changes.
            DialogResult result = MessageBox.Show(
                "You have unsaved changes. Do you want to save them?",
                "Save Changes?", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.No) return true;
            if (result == DialogResult.Cancel) return false;

            // Try to save the changes.
            Save();
            return !textRtb.Modified;
        }

        // Return true if we do not have a password.
        private bool NeedPassword()
        {
            // See if we have a password.
            if (passwordTextBox.Text.Length > 0) return false;

            // Ask for a password.
            MessageBox.Show("Please enter a password.",
                "Password Required", MessageBoxButtons.OK);
            return true;
        }

        // Save the file.
        private void Save()
        {
            // Make sure we have a password.
            if (NeedPassword()) return;

            // If we have no filename, treat this like Save As.
            if (Filename == null)
            {
                SaveAs();
                return;
            }

            // Try to save the with the existing file name.
            try
            {
                SaveFile(Filename);
            }
            catch
            {
                // Try saving with a new filename.
                SaveAs();
            }
        }

        // Save the file with a new name.
        private void SaveAs()
        {
            // Make sure we have a password.
            if (NeedPassword()) return;

            // Let the user select a filename.
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            // Try to save the file.
            SaveFile(saveFileDialog1.FileName);
        }

        // Try to save the file with the given file name.
        private void SaveFile(string cipherFilename)
        {
            try
            {
                // Save the file.
                string password = passwordTextBox.Text;
                string plaintext = textRtb.Rtf;
                plaintext.EncryptIntoFile(password, cipherFilename);
                
                // If we succeed, save the filename and mark the text as unmodified.
                Filename = cipherFilename;
                textRtb.Modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Try to load the file with the given file name.
        private void LoadFile()
        {
            try
            {
                // Make sure we have a password.
                if (NeedPassword()) return;

                // Make sure the data is safe.
                if (!DataIsSafe()) return;

                // Get the name of the file to load.
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                string cipherFilename = openFileDialog1.FileName;

                // Get the password.
                string password = passwordTextBox.Text;

                // Load the file.
                string plaintext = CryptoExtensions.DecryptFromFile(password, cipherFilename);
                textRtb.Rtf = plaintext;

                // If we succeed, save the filename and mark the text as unmodified.
                Filename = cipherFilename;
                textRtb.Modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Start a new document.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataIsSafe())
            {
                textRtb.Clear();
                textRtb.Modified = false;
            }
        }

        // Open an encrypted file.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        // Save into the previously loaded file.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Save into a new file.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        // Exit.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Make sure it's safe to exit.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel if the data is not safe.
            e.Cancel = !DataIsSafe();
        }
    }
}
