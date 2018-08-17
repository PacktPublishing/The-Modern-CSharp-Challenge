using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomizeItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The array and list.
        private string[] FirstNames;
        private List<string> LastNames;

        // Make the array and list.
        private void Form1_Load(object sender, EventArgs e)
        {
            FirstNames = new string[]
            {
                "Andy", "Betty", "Chuck", "Dina", "Ed", "Frieda"
            };

            LastNames = new List<string>(new string[]
            {
                "Anderson", "Baker", "Carter", "Dent", "Edwards", "Franklin"
            });

            // Display the values.
            arrayListBox.DataSource = FirstNames;
            listListBox.DataSource = LastNames;
        }

        // Random the names.
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            arrayListBox.DataSource = null;
            listListBox.DataSource = null;

            FirstNames.Randomize();
            LastNames.Randomize();

            arrayListBox.DataSource = FirstNames;
            listListBox.DataSource = LastNames;
        }
    }
}
