using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BytesToHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Convert the original text into hexadecimal.
        private void toHexButton_Click(object sender, EventArgs e)
        {
            // Convert the string into a byte array.
            string original = originalTextBox.Text;
            byte[] bytes = original.StringToBytes();

            // Convert the byte array into a hexadecimal string.
            hexTextBox.Text = bytes.BytesToHex(' ');
        }

        // Convert the hexadecimal back into text.
        private void toStringButton_Click(object sender, EventArgs e)
        {
            // Convert the hexadecimal string into a byte array.
            string hex = hexTextBox.Text;
            byte[] bytes = hex.HexToBytes();

            // Convert the byte array into a string.
            stringTextBox.Text = bytes.BytesToString();
        }
    }
}
