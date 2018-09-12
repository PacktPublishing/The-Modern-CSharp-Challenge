using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace HailstoneSequenceRedux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            lengthLabel.Text = "";
            Refresh();

            // Find the hailstone sequence lengths.
            int max = int.Parse(numberTextBox.Text);
            List<int> lengths = FindHailstoneLengths(max);

            // Display the results.
            resultTextBox.Text = string.Join(" ", lengths.ToArray());
            lengthLabel.Text = lengths.Count().ToString();

            // Graph the results.
            int wid = sequencePictureBox.ClientSize.Width;
            int hgt = sequencePictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Clear(Color.White);

                // Set up a transformation.
                RectangleF graphRect = new RectangleF(
                    0, 0, lengths.Count(), lengths.Max());
                const int margin = 5;
                RectangleF bitmapRect = new RectangleF(
                    margin, margin, wid - 1 - 2 * margin, hgt - 1 - 2 * margin);
                SetTransformation(gr, graphRect, bitmapRect, false, true);

                using (Pen pen = new Pen(Color.Black, 0))
                {
                    // Draw axes.
                    gr.DrawLine(pen, 0, -10000, 0, 10000);
                    gr.DrawLine(pen, -10000, 0, 10000, 0);

                    // Draw the sequence.
                    pen.Color = Color.Red;
                    List<PointF> points = new List<PointF>();
                    for (int x = 0; x < lengths.Count; x++)
                        points.Add(new PointF(x, lengths[x]));
                    gr.DrawLines(pen, points.ToArray());
                }
            }
            sequencePictureBox.Image = bm;
        }

        // Return the lengths of hailstone sequences for starting numbers 1 through max.
        private List<int> FindHailstoneLengths(int max)
        {
            // Create an array to hold the lengths.
            int[] lengths = new int[max + 1];

            // Fill the lengths.
            for (int i = 1; i <= max; i++)
            {
                int length = 1;
                int number = i;
                while (number != 1)
                {
                    // See if we know the length for the current number.
                    if ((number <= max) && (lengths[number] > 0))
                    {
                        // We know lengths[number].
                        length += lengths[number] - 1;
                        break;
                    }

                    // Go to the next number.
                    length++;
                    if (number % 2 == 0)
                        number = number / 2;
                    else
                        number = 3 * number + 1;
                }
                lengths[i] = length;
            }

            // Convert the array to a list and remove the entry 0.
            List<int> lengthList = new List<int>(lengths);
            lengthList.RemoveAt(0);

            return lengthList;
        }

        // Map from world coordinates to screen coordinates.
        private void SetTransformation(Graphics gr,
            RectangleF graphRect, RectangleF bitmapRect,
            bool invertX, bool invertY)
        {
            PointF[] bitmapPoints =
            {
                new PointF(bitmapRect.Left, bitmapRect.Top),    // Upper left.
                new PointF(bitmapRect.Right, bitmapRect.Top),   // Upper right.
                new PointF(bitmapRect.Left, bitmapRect.Bottom), // Lower left.
            };

            if (invertX)
            {
                bitmapPoints[0].X = bitmapRect.Right;
                bitmapPoints[1].X = bitmapRect.Left;
                bitmapPoints[2].X = bitmapRect.Right;
            }
            if (invertY)
            {
                bitmapPoints[0].Y = bitmapRect.Bottom;
                bitmapPoints[1].Y = bitmapRect.Bottom;
                bitmapPoints[2].Y = bitmapRect.Top;
            }

            gr.Transform = new Matrix(graphRect, bitmapPoints);
        }
    }
}
