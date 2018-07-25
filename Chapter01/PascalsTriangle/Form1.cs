using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascalsTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Make and display Pascal's triangle.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Get the number of rows.
            int numRows = int.Parse(numRowsTextBox.Text);

            // Get the Pascal's triangle.
            List<List<int>> triangle = MakePascalsTriangle(numRows);

            // Convert the triangle into a string and display it.
            triangleTextBox.Text = TriangleToString(triangle);
        }

        // Make a Pascal's triangle with the desired number of rows.
        private List<List<int>> MakePascalsTriangle(int numRows)
        {
            // Make the result list.
            List<List<int>> triangle = new List<List<int>>();

            // Make the first row.
            List<int> prevRow = new List<int>();
            prevRow.Add(1);
            triangle.Add(prevRow);

            // Make the other rows.
            for (int rowNum = 2; rowNum <= numRows; rowNum++)
            {
                // Make the next row.
                List<int> newRow = new List<int>();
                newRow.Add(1);
                for (int colNum = 2; colNum < rowNum; colNum++)
                {
                    newRow.Add(
                        prevRow[colNum - 2] +
                        prevRow[colNum - 1]);
                }
                newRow.Add(1);

                // Prepare for the next row.
                triangle.Add(newRow);
                prevRow = newRow;
            }

            return triangle;
        }

        // Convert a Pascal's triangle into a string.
        private string TriangleToString(List<List<int>> triangle)
        {
            StringBuilder sb = new StringBuilder();
            foreach (List<int> row in triangle)
            {
                sb.AppendLine(
                    string.Join(" ",
                        row.ConvertAll(i => i.ToString())));
            }
            return sb.ToString();
        }
    }
}
