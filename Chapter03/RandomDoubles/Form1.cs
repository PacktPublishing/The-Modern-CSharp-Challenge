using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDoubles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Random object used by this program.
        private Random Rand = new Random();

        // Generate some random values.
        private void goButton_Click(object sender, EventArgs e)
        {
            double min = double.Parse(minTextBox.Text);
            double max = double.Parse(maxTextBox.Text);
            doublesListBox.Items.Clear();
            for (int i = 0; i < 100; i++)
                doublesListBox.Items.Add(Rand.NextDouble(min, max));
        }
    }
}
