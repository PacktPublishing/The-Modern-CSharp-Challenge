using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Convert from Arabic to Roman.
        private void toRomanButton_Click(object sender, EventArgs e)
        {
            long arabic = long.Parse(arabicTextBox.Text);
            romanTextBox.Text = arabic.ToRoman();
            arabicTextBox.Clear();
        }

        // Convert from Roman to Arabic.
        private void toArabicButton_Click(object sender, EventArgs e)
        {
            long roman = romanTextBox.Text.ToArabic();
            arabicTextBox.Text = roman.ToString();
            romanTextBox.Clear();
        }
    }
}
