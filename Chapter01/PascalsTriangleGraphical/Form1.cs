using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace PascalsTriangleGraphical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Pascal's triangle.
        private List<List<int>> PascalsTriangle = null;

        // Build and display the triangle.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Get the number of rows.
            int numRows = int.Parse(numRowsTextBox.Text);

            // Get the Pascal's triangle.
            PascalsTriangle = MakePascalsTriangle(numRows);

            // Redraw.
            trianglePictureBox.Refresh();
        }

        // Make a Pascal's triangle with the desired number of levels.
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
                for (int i = 0; i < row.Count; i++)
                {
                    sb.Append(row[i]);
                    if (i < row.Count - 1) sb.Append('\t');
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        // Redraw the current Pascal's triangle.
        private void trianglePictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawTriangle(e.Graphics, trianglePictureBox.ClientSize.Width / 2);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            trianglePictureBox.Refresh();
        }

        // Draw the triangle on the PictureBox.
        private void DrawTriangle(Graphics gr, int cx)
        {
            gr.Clear(Color.White);
            if (PascalsTriangle == null) return;
            gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            gr.SmoothingMode = SmoothingMode.AntiAlias;

            // The size of an item.
            const int wid = 30;
            const int hgt = 30;
            const int margin = 2;

            // Make a StringFormat to center text.
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                // Make a font to use.
                using (Font font = new Font("Segoe", 9))
                {
                    int y = 4;

                    // Draw each row.
                    int numRows = PascalsTriangle.Count;
                    for (int rowNum = 1; rowNum <= numRows; rowNum++)
                    {
                        // Start on the left so the row is centered.
                        int x = cx - rowNum * wid / 2;

                        // Draw the items in this row.
                        List<int> row = PascalsTriangle[rowNum - 1];
                        for (int colNum = 1; colNum <= rowNum; colNum++)
                        {
                            Rectangle rect = new Rectangle(
                                x + margin, y + margin,
                                wid - 2 * margin, hgt - 2 * margin);
                            gr.DrawString(row[colNum - 1].ToString(),
                                font, Brushes.Blue, rect, sf);
                            gr.DrawEllipse(Pens.Black, rect);
                            x += wid;
                        }
                        y += hgt;
                    }
                }
            }
        }
    }
}
