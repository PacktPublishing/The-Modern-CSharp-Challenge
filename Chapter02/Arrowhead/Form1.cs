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

namespace Arrowhead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The segment's end point. If they are the same, there's no segment.
        private Point StartPoint, EndPoint;

        // True while dragging.
        private bool Drawing = false;

        // Start drawing.
        private void arrowPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            StartPoint = e.Location;
            EndPoint = e.Location;
            arrowPictureBox.Refresh();
        }

        // Continue drawing.
        private void arrowPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Drawing) return;

            EndPoint = e.Location;
            arrowPictureBox.Refresh();
        }

        // Stop drawing.
        private void arrowPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Drawing) return;
            Drawing = false;

            EndPoint = e.Location;
            arrowPictureBox.Refresh();
        }

        // Draw the arrow.
        private void arrowPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (StartPoint == EndPoint) return;

            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Make a thick pen.
            using (Pen pen = new Pen(Color.Red, 5))
            {
                pen.LineJoin = LineJoin.Round;
                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                // Draw the segment.
                e.Graphics.DrawLine(pen, StartPoint, EndPoint);

                // Draw the arrowhead and tail.
                DrawArrowPart(e.Graphics, pen, StartPoint, EndPoint, 15, false);
                DrawArrowPart(e.Graphics, pen, EndPoint, StartPoint, 15, true);
            }
        }

        // Draw an arrowhead wedge at point p1.
        // If reversed is true, make an arrow tail.
        private void DrawArrowPart(Graphics gr, Pen pen, Point p0, Point p1, 
            float sideLength, bool reversed)
        {
            // Get a vector along the arrow's length.
            float vx = p1.X - p0.X;
            float vy = p1.Y - p0.Y;

            // If this should be a tail, reverse the vectors.
            if (reversed)
            {
                vx = -vx;
                vy = -vy;
            }

            // Get perpendicular vectors.
            float p0x = vy;
            float p0y = -vx;
            float p1x = -vy;
            float p1y = vx;

            // Get arrowhead/tail vectors.
            float headX0 = p0x - vx;
            float headY0 = p0y - vy;
            float headX1 = p1x - vx;
            float headY1 = p1y - vy;

            // Set the vectors' lengths.
            float length0 = (float)Math.Sqrt(headX0 * headX0 + headY0 * headY0);
            headX0 *= sideLength / length0;
            headY0 *= sideLength / length0;
            float length1 = (float)Math.Sqrt(headX1 * headX1 + headY1 * headY1);
            headX1 *= sideLength / length1;
            headY1 *= sideLength / length1;

            // Draw it.
            PointF[] points =
            {
                new PointF(p1.X + headX0, p1.Y + headY0),
                p1,
                new PointF(p1.X + headX1, p1.Y + headY1),
            };
            gr.DrawLines(pen, points);
        }
    }
}
