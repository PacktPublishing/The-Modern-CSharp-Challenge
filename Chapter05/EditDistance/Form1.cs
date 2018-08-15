using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Direction
        {
            FromAbove,
            FromLeft,
            FromDiagonal
        }

        private struct Node
        {
            public int Distance;
            public Direction Direction;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Make the edit graph.
            string word1 = word1TextBox.Text;
            string word2 = word2TextBox.Text;
            Node[,] graph = MakeEditGraph(word1, word2);

            // Display the distance.
            int numRows = graph.GetUpperBound(0) + 1;
            int numCols = graph.GetUpperBound(1) + 1;
            distanceTextBox.Text =
                graph[numRows - 1, numCols - 1].Distance.ToString();

            // Display the changes.
            List<string> moves = DescribePath(graph, word1, word2);
            changesListBox.DataSource = moves;
        }

        // Fill in the edit graph for two strings.
        private Node[,] MakeEditGraph(string string1, string string2)
        {
            // Make the edit graph array.
            int numCols = string1.Length + 1;
            int numRows = string2.Length + 1;
            Node[,] nodes = new Node[numRows, numCols];

            // Initialize the leftmost column.
            for (int r = 0; r < numRows; r++)
            {
                nodes[r, 0].Distance = r;
                nodes[r, 0].Direction = Direction.FromAbove;
            }

            // Initialize the top row.
            for (int c = 0; c < numCols; c++)
            {
                nodes[0, c].Distance = c;
                nodes[0, c].Direction = Direction.FromLeft;
            }

            // Fill in the rest of the array.
            char[] chars1 = string1.ToCharArray();
            char[] chars2 = string2.ToCharArray();
            for (int c = 1; c < numCols; c++)
            {
                // Fill in column c.
                for (int r = 1; r < numRows; r++)
                {
                    // Fill in entry [r, c].
                    // Check the three possible paths to here.
                    int distance1 = nodes[r - 1, c].Distance + 1;
                    int distance2 = nodes[r, c - 1].Distance + 1;
                    int distance3 = int.MaxValue;
                    if (chars1[c - 1] == chars2[r - 1])
                    {
                        // There is a diagonal link.
                        distance3 = nodes[r - 1, c - 1].Distance;
                    }

                    // See which is cheapest.
                    if ((distance1 <= distance2) && (distance1 <= distance3))
                    {
                        // Come from above.
                        nodes[r, c].Distance = distance1;
                        nodes[r, c].Direction = Direction.FromAbove;
                    }
                    else if (distance2 <= distance3)
                    {
                        // Come from the left.
                        nodes[r, c].Distance = distance2;
                        nodes[r, c].Direction = Direction.FromLeft;
                    }
                    else
                    {
                        // Come from the diagonal.
                        nodes[r, c].Distance = distance3;
                        nodes[r, c].Direction = Direction.FromDiagonal;
                    }
                }
            }
            return nodes;
        }

        // Make a list showing the transformation from word1 to word2.
        private List<string> DescribePath(Node[,] graph, string word1, string word2)
        {
            //  Build the path backward.
            int numRows = graph.GetUpperBound(0) + 1;
            int numCols = graph.GetUpperBound(1) + 1;
            int r = numRows - 1;
            int c = numCols - 1;

            List<string> moves = new List<string>();
            string word = word2;
            moves.Add("End with:\t" + word);

            while ((r > 0) || (c > 0))
            {
                switch (graph[r, c].Direction)
                {
                    case Direction.FromAbove:
                        // We added letter r. Remove it.
                        moves.Add("Add " + word2.Substring(r - 1, 1) +
                            " to get:\t" + word);
                        word = word.Remove(r - 1, 1);
                        r--;
                        break;
                    case Direction.FromLeft:
                        // We removed letter c. Re-add it.
                        moves.Add("Remove " + word1.Substring(c - 1, 1) +
                            " to get:\t" + word);
                        word = word.Insert(r, word1.Substring(c - 1, 1));
                        c--;
                        break;
                    case Direction.FromDiagonal:
                        // We did nothing.
                        //moves.Add("Keep " + word1.Substring(c - 1, 1) +
                        //    " to get:\t" + word);
                        r--;
                        c--;
                        break;
                }
            }
            moves.Add("Start with word:\t" + word1);

            // Reverse the moves.
            moves.Reverse();
            return moves;
        }
    }
}
