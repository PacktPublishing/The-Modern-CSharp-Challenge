using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Save the image in the appropriate format.
        private void saveButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.SaveImage(filenameTextBox.Text);
            filenameTextBox.Clear();
            filenameTextBox.Focus();
        }
    }
}
