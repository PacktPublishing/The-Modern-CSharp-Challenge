using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Encrypt.
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string key = encryptKeyTextBox.Text;
            string plaintext = plaintextTextBox.Text;
            ciphertextTextBox.Text = plaintext.VigenereEncrypt(key);
        }

        // Decrypt.
        private void decryptButton_Click(object sender, EventArgs e)
        {
            string key = decryptKeyTextBox.Text;
            string ciphertext = ciphertextTextBox.Text;
            recoveredTextBox.Text = ciphertext.VigenereDecrypt(key);
        }
    }
}
