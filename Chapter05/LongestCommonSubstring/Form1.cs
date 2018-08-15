using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace LongestCommonSubstring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The quotes:
        // The secret of life is honesty and fair dealing. If you can fake that, you've got it made. -- Groucho Marx
        // There are people who think that honesty is always the best policy. This is a superstition. There are times when the appearance of it is worth six of it. -- Mark Twain

        // Find the longest matching substrings.
        private void searchButton_Click(object sender, EventArgs e)
        {
            result1TextBox.Clear();
            result2TextBox.Clear();
            result3TextBox.Clear();
            time1TextBox.Clear();
            time2TextBox.Clear();
            time3TextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            string string1 = string1TextBox.Text;
            string string2 = string2TextBox.Text;
            int numTrials = int.Parse(numTrialsTextBox.Text);
            string result = "";

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int trial = 0; trial < numTrials; trial++)
            {
                result = FindLongestSubstring1(string1, string2);
            }
            watch.Stop();
            result1TextBox.Text = result;
            time1TextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            watch.Restart();
            for (int trial = 0; trial < numTrials; trial++)
            {
                result = FindLongestSubstring2(string1, string2);
            }
            watch.Stop();
            result2TextBox.Text = result;
            time2TextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            watch.Restart();
            for (int trial = 0; trial < numTrials; trial++)
            {
                result = FindLongestSubstring3(string1, string2);
            }
            watch.Stop();
            result3TextBox.Text = result;
            time3TextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Refresh();

            Cursor = Cursors.Default;
        }

        // Find the longest substring by examining every possible substring in string1.
        private string FindLongestSubstring1(string string1, string string2)
        {
            string bestSubstring = "";
            int bestLength = 0;

            // Loop over all possible starting positions.
            for (int startPos = 0; startPos < string1.Length - 1; startPos++)
            {
                // Loop over possible lengths starting at this position.
                for (int length = bestLength + 1; length <= string1.Length - startPos; length++)
                {
                    string testSubstring = string1.Substring(startPos, length);
                    int testPos = string2.IndexOf(testSubstring);
                    if (testPos >= 0)
                    {
                        bestLength = length;
                        bestSubstring = testSubstring;
                    }
                }
            }

            return bestSubstring;
        }
        // Find the longest substring by examining every possible substring in string1.
        private string FindLongestSubstring2(string string1, string string2)
        {
            string bestSubstring = "";
            int bestLength = 0;

            // Loop over all possible starting positions.
            for (int startPos = 0; startPos < string1.Length - 1; startPos++)
            {
                // Loop over possible lengths starting at this position.
                for (int length = bestLength + 1; length <= string1.Length - startPos; length++)
                {
                    string testSubstring = string1.Substring(startPos, length);
                    int testPos = string2.IndexOf(testSubstring);
                    if (testPos < 0) break;

                    bestLength = length;
                    bestSubstring = testSubstring;
                }
            }

            return bestSubstring;
        }

        // Use a dynamic table to find the longest substring.
        private string FindLongestSubstring3(string string1, string string2)
        {
            int[,] num = new int[string1.Length + 1, string2.Length + 1];
            int bestLength = 0;
            int bestEnd = -1;

            for (int i = 1; i < string1.Length + 1; i++)
            {
                char ch1 = string1[i - 1];
                for (int j = 1; j < string2.Length + 1; j++)
                {
                    char ch2 = string2[j - 1];

                    // Compare the characters.
                    if (ch1 != ch2)
                        // They don't match. No matching substring here.
                        num[i, j] = 0;
                    else
                    {
                        // They match.
                        num[i, j] = num[i - 1, j - 1] + 1;

                        // See if this is better than the best found so far.
                        if (num[i, j] > bestLength)
                        {
                            bestLength = num[i, j];
                            bestEnd = i;
                        }
                    }
                }
            }
            int bestStart = bestEnd - bestLength + 1;
            return string1.Substring(bestStart - 1, bestLength);
        }
    }
}
