using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permutations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Clear previous results.
            resultsListBox.Items.Clear();
            numPermutationsLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            // Get the inputs.
            char[] separators = { ' ' };
            string[] values = valuesTextBox.Text.Split(
                separators, StringSplitOptions.RemoveEmptyEntries);
            int numPerGroup = int.Parse(numPerGroupTextBox.Text);

            // Get the permutations.
            List<List<string>> permutations;
            if (numPerGroup == 0)
                permutations = values.Permutations();
            else
                permutations = values.Permutations(numPerGroup);

            // Display the results.
            foreach (List<string> permutation in permutations)
                resultsListBox.Items.Add(string.Join(" ", permutation.ToArray()));

            numPermutationsLabel.Text = permutations.Count().ToString();
            Cursor = Cursors.Default;
        }
    }
}
