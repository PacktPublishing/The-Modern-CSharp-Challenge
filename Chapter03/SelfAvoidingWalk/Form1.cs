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

namespace SelfAvoidingWalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The lattice size.
        private int WalkWidth, WalkHeight;

        // The walk.
        private List<Point> Walk = new List<Point>();

        // Make a random walk.
        private void Form1_Load(object sender, EventArgs e)
        {
            MakeWalk();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MakeWalk();
        }

        // Make and display a walk.
        private void MakeWalk()
        {
            WalkWidth = int.Parse(widthTextBox.Text);
            WalkHeight = int.Parse(heightTextBox.Text);
            Walk = FindWalk(WalkWidth, WalkHeight);
            walkPictureBox.Refresh();
        }

        // Find a random self-avoiding walk.
        private List<Point> FindWalk(int width, int height)
        {
            // Make an array to show where we have been.
            bool[,] visited = new bool[width, height];

            // Start at a random vertex.
            Random rand = new Random();
            int x = rand.Next(0, width);
            int y = rand.Next(0, height);

            // Start the walk at (x, y).
            List<Point> walk = new List<Point>();
            walk.Add(new Point(x, y));
            visited[x, y] = true;

            // Repeat until we can no longer move.
            for (;;)
            {
                // Make a list of potential neighbors.
                List<Point> candidates = new List<Point>();
                candidates.Add(new Point(x - 1, y));
                candidates.Add(new Point(x + 1, y));
                candidates.Add(new Point(x, y - 1));
                candidates.Add(new Point(x, y + 1));

                // See which neighbors are on the lattice and unvisited.
                List<Point> neighbors = new List<Point>();
                foreach (Point point in candidates)
                    if ((point.X >= 0) && (point.X < width) &&
                        (point.Y >= 0) && (point.Y < height) &&
                        !visited[point.X, point.Y])
                        neighbors.Add(point);

                // If we have no unvisited neighbors, then we're stuck.
                if (neighbors.Count == 0) break;

                // Pick a random neighbor to visit.
                Point next = neighbors.Random();

                // Go there.
                walk.Add(next);
                visited[next.X, next.Y] = true;
                x = next.X;
                y = next.Y;
            }

            return walk;
        }

        // Draw the walk.
        private void walkPictureBox_Paint(object sender, PaintEventArgs e)
        {
            int picWidth = walkPictureBox.ClientSize.Width;
            int picHeight = walkPictureBox.ClientSize.Height;

            // See how big to make each row and column.
            float scaleX = picWidth / (float)(WalkWidth + 1);
            float scaleY = picHeight / (float)(WalkHeight + 1);
            float scale = Math.Min(scaleX, scaleY);
            float xOffset = (picWidth - scale * (WalkWidth - 1)) / 2;
            float yOffset = (picHeight - scale * (WalkHeight - 1)) / 2;
            float dotR = scaleX * 0.1f;
            float dotW = 2 * dotR;

            // Draw the walk.
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.White);

            // Draw a grid of dots.
            for (int x = 0; x < WalkWidth; x++)
            {
                for (int y = 0; y < WalkHeight; y++)
                {
                    e.Graphics.FillEllipse(Brushes.Black,
                        xOffset + x * scale - dotR,
                        yOffset + y * scale - dotR,
                        dotW, dotW);
                }
            }

            // Draw the walk.
            RectangleF rect = new RectangleF(
                xOffset + Walk[0].X * scale - 2 * dotR,
                yOffset + Walk[0].Y * scale - 2 * dotR,
                4 * dotR, 4 * dotR);
            e.Graphics.DrawEllipse(Pens.Red, rect);

            List<PointF> points = new List<PointF>();
            foreach (Point point in Walk)
            {
                points.Add(new PointF(
                    xOffset + point.X * scale,
                    yOffset + point.Y * scale));
            }
            e.Graphics.DrawLines(Pens.Red, points.ToArray());
        }
    }
}
