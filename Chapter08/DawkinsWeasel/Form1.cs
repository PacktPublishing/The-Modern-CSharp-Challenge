using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DawkinsWeasel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random Rand = new Random();
        private string Target, Letters;
        private int TargetLength;

        private void Form1_Load(object sender, EventArgs e)
        {
            Target = "METHINKS IT IS LIKE A WEASEL";
            TargetLength = Target.Length;
            Letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            stepsListBox.Items.Clear();

            int generationSize = int.Parse(generationSizeTextBox.Text);
            double mutationProb = double.Parse(mutationProbTextBox.Text);

            RunWeasel(generationSize, mutationProb);
        }

        // Perform the weasel transformation.
        private void RunWeasel(int generationSize, double mutationProb)
        {
            // Start with a random string.
            string parent = RandomString(Letters, TargetLength);

            // Repeat until we find the target.
            int error = FindError(parent, Target);
            while (error > 0)
            {
                // Display this parent.
                stepsListBox.Items.Add(error + ": " + parent);

                // Process a generation.
                int bestError = int.MaxValue;
                string bestOffspring = "";
                for (int i = 0; i < generationSize; i++)
                {
                    // Make a mutated offspring.
                    string testOffspring = "";
                    foreach (char ch in parent)
                    {
                        if (Rand.NextDouble() <= mutationProb)
                            testOffspring += RandomLetter(Letters);
                        else
                            testOffspring += ch;
                    }

                    // See if this is an improvement.
                    int testError = FindError(testOffspring, Target);
                    if (testError < bestError)
                    {
                        bestError = testError;
                        bestOffspring = testOffspring;
                    }
                }

                // Replace the parent with the best offspring.
                parent = bestOffspring;
                error = bestError;
            }
            numStepsLabel.Text = $"# Steps: {stepsListBox.Items.Count.ToString()}";

            stepsListBox.Items.Add(error + ": " + parent);
            stepsListBox.SelectedIndex = stepsListBox.Items.Count - 1;
        }

        private string RandomString(string letters, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
                result += RandomLetter(letters);
            return result;
        }

        private char RandomLetter(string letters)
        {
            int index = Rand.Next(0, letters.Length);
            return letters[index];
        }

        private int FindError(string string1, string string2)
        {
            int error = 0;
            for (int i = 0; i < string1.Length; i++)
                error += Math.Abs((int)string1[i] - (int)string2[i]);
            return error;
        }
    }
}
