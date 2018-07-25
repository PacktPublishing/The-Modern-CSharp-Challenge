using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combinations
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
            numCombinationsLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            // Get the inputs.
            char[] separators = { ' ' };
            string[] values = valuesTextBox.Text.Split(
                separators, StringSplitOptions.RemoveEmptyEntries);
            int numPerGroup = int.Parse(numPerGroupTextBox.Text);

            // Get the combinations.
            List<List<string>> combinations;
            if (numPerGroup == 0)
                combinations = values.Combinations();
            else
                combinations = values.Combinations(numPerGroup);

            // Display the results.
            foreach (List<string> combination in combinations)
                resultsListBox.Items.Add(string.Join(" ", combination.ToArray()));

            numCombinationsLabel.Text = combinations.Count().ToString();
            Cursor = Cursors.Default;
        }
    }
}
