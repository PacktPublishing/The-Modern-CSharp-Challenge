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
using System.Security.Cryptography;

namespace EncryptDecryptFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Let the user select the plainfile name.
        private void browsePlainfileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = plainfileTextBox.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                plainfileTextBox.Text = openFileDialog1.FileName;
            }
        }

        // Let the user select the cipherfile name.
        private void browseCipherfileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = cipherfileTextBox.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cipherfileTextBox.Text = saveFileDialog1.FileName;
            }
        }

        // Let the user select the recoverfile name.
        private void browseRecoverfileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = recoverfileTextBox.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                recoverfileTextBox.Text = saveFileDialog1.FileName;
            }
        }

        // Encrypt the file.
        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Encrypt the file.
                string password = encryptPasswordTextBox.Text;
                string plainfile = plainfileTextBox.Text;
                string cipherfile = cipherfileTextBox.Text;
                CryptoExtensions.EncryptFile(password, plainfile, cipherfile);

                // Show the results.
                plaintextRtb.LoadFile(plainfile);

                // Make sure we don't try to show too many bytes.
                byte[] cipherbytes = File.ReadAllBytes(cipherfile);
                const int maxBytes = 1000;
                if (cipherbytes.Length > maxBytes)
                {
                    byte[] bytes = new byte[maxBytes];
                    Array.Copy(cipherbytes, bytes, maxBytes);
                    cipherbytes = bytes;
                }
                ciphertextTextBox.Text = cipherbytes.BytesToHex();
            }
            catch (Exception ex)
            {
                string stars = new string('*', ex.Message.Length);
                ciphertextTextBox.Text = $"{stars}\n{ex.Message}\n{stars}";
            }
        }

        // Decrypt the file.
        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Decrypt the file.
                string password = decryptPasswordTextBox.Text;
                string cipherfile = cipherfileTextBox.Text;
                string recoverfile = recoverfileTextBox.Text;
                CryptoExtensions.DecryptFile(password, cipherfile, recoverfile);

                // Show the results.
                recovertextRtb.LoadFile(recoverfile);
            }
            catch (Exception ex)
            {
                string stars = new string('*', ex.Message.Length);
                recovertextRtb.Text = $"{stars}\n{ex.Message}\n{stars}";
            }
        }

        // Clear any previous results.
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ciphertextTextBox.Clear();
            recovertextRtb.Clear();
        }

        // Clear any previously recovered data.
        private void Decrypt_TextChanged(object sender, EventArgs e)
        {
            recovertextRtb.Clear();
        }
    }
}
