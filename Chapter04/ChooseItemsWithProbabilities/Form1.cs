using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseItemsWithProbabilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The list, array, and probabilities.
        private char[] LetterArray;
        private List<char> LetterList;
        private double[] Probabilities = { 0.1, 0.2, 0.3, 0.4 };

        // Make the list and array.
        private void Form1_Load(object sender, EventArgs e)
        {
            LetterArray = new char[] { 'A', 'B', 'C', 'D' };
            LetterList = new List<char>(LetterArray);
        }

        // Pick letters with the given probabilities.
        private void chooseButton_Click(object sender, EventArgs e)
        {
            arrayListBox.Items.Clear();
            listListBox.Items.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            int numTrials = int.Parse(numTrialsTextBox.Text);

            // Work with the array.
            int[] counts = new int[4];
            for (int i = 0; i < numTrials; i++)
            {
                char letter = LetterArray.PickWithProbability(Probabilities);
                int index = letter - 'A';
                counts[index]++;
            }
            for (int i = 0; i < 4; i++)
            {
                char letter = (char)('A' + i);
                double percent = counts[i] / (double)numTrials;
                arrayListBox.Items.Add(letter + ": " + percent.ToString("P"));
            }

            // Work with the list.
            counts = new int[4];
            for (int i = 0; i < numTrials; i++)
            {
                char letter = LetterList.PickWithProbability(Probabilities);
                int index = letter - 'A';
                counts[index]++;
            }
            for (int i = 0; i < 4; i++)
            {
                char letter = (char)('A' + i);
                double percent = counts[i] / (double)numTrials;
                listListBox.Items.Add(letter + ": " + percent.ToString("P"));
            }

            Cursor = Cursors.Default;
        }
    }
}
