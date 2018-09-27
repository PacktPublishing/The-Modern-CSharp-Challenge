using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace EncryptDecryptStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Clear previous results.
        private void plaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            ciphertextTextBox.Clear();
            recoveredTextBox.Clear();
        }

        // Encrypt the text.
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string password = encryptPasswordTextBox.Text;
            string plaintext = plaintextTextBox.Text;
            byte[] cipherbytes = plaintext.Encrypt(password);
            ciphertextTextBox.Text = cipherbytes.BytesToHex();
        }

        // Decrypt the text.
        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = decryptPasswordTextBox.Text;
                string ciphertext = ciphertextTextBox.Text;
                byte[] cipherbytes = ciphertext.HexToBytes();
                recoveredTextBox.Text = cipherbytes.Decrypt(password);
            }
            catch (CryptographicException)
            {
                // The password is invalid.
                recoveredTextBox.Text = "*** Invalid password. ***";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
