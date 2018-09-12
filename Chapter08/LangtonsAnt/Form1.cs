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

namespace LangtonsAnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The size of a square.
        private const int Wid = 6;

        // The size of the world.
        private int Wxmax, Wymax;

        // The PictureBox dimensions.
        private int Dxmax, Dymax;

        // The world.
        private bool[,] SquareIsBlack = null;

        // The turn number.
        private int TurnNumber = 0;

        // The ant's current location and direction.
        private Point AntLocation = new Point(1, 1);
        private enum Direction { Up, Right, Down, Left }
        private Direction AntDirection = Direction.Left;

        // Make the World array and get geometry values.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            Wxmax = worldPictureBox.ClientSize.Width / Wid;
            Wymax = worldPictureBox.ClientSize.Height / Wid;
            SquareIsBlack = new bool[Wxmax, Wymax];

            Dxmax = worldPictureBox.ClientSize.Width;
            Dymax = worldPictureBox.ClientSize.Height;

            AntLocation = new Point(Wxmax / 2, Wymax / 2);
            AntDirection = Direction.Up;
        }

        // Toggle a square.
        private void worldPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Find the point in world coordinates.
            int x = e.Location.X / Wid;
            int y = e.Location.Y / Wid;
            if ((x >= Wxmax) || (y >= Wymax)) return;

            // Toggle the square clicked.
            SquareIsBlack[x, y] = !SquareIsBlack[x, y];

            // Redraw.
            worldPictureBox.Refresh();
        }

        // Draw the current world.
        private void worldPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the grid.
            using (Pen pen = new Pen(Color.Gray, 0))
            {
                for (int x = 0; x <= Wxmax; x++)
                    e.Graphics.DrawLine(pen, x * Wid, 0, x * Wid, Dymax);
                for (int y = 0; y <= Wymax; y++)
                    e.Graphics.DrawLine(pen, 0, y * Wid, Dxmax, y * Wid);
            }

            // Draw the squares.
            for (int x = 0; x < Wxmax; x++)
            {
                for (int y = 0; y < Wymax; y++)
                {
                    if (SquareIsBlack[x, y])
                    {
                        e.Graphics.FillRectangle(Brushes.Black,
                            x * Wid, y * Wid, Wid - 1, Wid - 1);
                    }
                }
            }

            // Draw the ant.
            DrawAnt(e.Graphics);
        }

        // Draw a triangle pointing in the ant's direction.
        private void DrawAnt(Graphics gr)
        {
            //e.Graphics.FillRectangle(Brushes.Red,
            //    AntLocation.X * Wid, AntLocation.Y * Wid,
            //    Wid - 1, Wid - 1);

            float x = AntLocation.X * Wid;
            float y = AntLocation.Y * Wid;
            float xmid = x + Wid * 0.5f;
            float ymid = y + Wid * 0.5f;
            PointF[] points = null;
            switch (AntDirection)
            {
                case Direction.Up:
                    points = new PointF[]
                    {
                        new PointF(x, y + Wid),
                        new PointF(x + Wid, y + Wid),
                        new PointF(xmid, y),
                    };
                    break;
                case Direction.Right:
                    points = new PointF[]
                    {
                        new PointF(x, y),
                        new PointF(x, y + Wid),
                        new PointF(x + Wid, ymid),
                    };
                    break;
                case Direction.Down:
                    points = new PointF[]
                    {
                        new PointF(x, y),
                        new PointF(x + Wid, y),
                        new PointF(xmid, y + Wid),
                    };
                    break;
                case Direction.Left:
                    points = new PointF[]
                    {
                        new PointF(x + Wid, y),
                        new PointF(x + Wid, y + Wid),
                        new PointF(x, ymid),
                    };
                    break;
            }
            gr.FillPolygon(Brushes.Red, points);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void intervalScrollBar_ValueChanged(object sender, EventArgs e)
        {
            moveTimer.Interval = intervalScrollBar.Value;
            intervalLabel.Text = $"Interval ({moveTimer.Interval} ms):";
        }

        // Start or stop the simulation.
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "&Start")
            {
                startToolStripMenuItem.Text = "&Stop";
                moveTimer.Enabled = true;
            }
            else
            {
                startToolStripMenuItem.Text = "&Start";
                moveTimer.Enabled = false;
            }
        }

        // Clear the world.
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SquareIsBlack = new bool[Wxmax, Wymax];
            worldPictureBox.Refresh();
        }

        // Make a purely random pattern.
        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int y = 0; y < Wymax; y++)
            {
                for (int x = 0; x < Wxmax; x++)
                {
                    SquareIsBlack[x, y] = (rand.Next(0, 2) == 1);
                }
            }
            worldPictureBox.Refresh();
        }

        private void centerAntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AntLocation = new Point(Wxmax / 2, Wymax / 2);
            AntDirection = Direction.Up;
            Refresh();
        }

        private void resetCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnNumber = 0;
            turnLabel.Text = "0";
        }

        // Move the ant.
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // Get the ant's new direction.
            if (SquareIsBlack[AntLocation.X, AntLocation.Y])
                // Turn right.
                AntDirection = (Direction)(((int)AntDirection + 1) % 4);
            else
                // Turn left.
                AntDirection = (Direction)(((int)AntDirection - 1 + 4) % 4);

            // Toggle the current square's color.
            SquareIsBlack[AntLocation.X, AntLocation.Y] =
                !SquareIsBlack[AntLocation.X, AntLocation.Y];

            // Move the ant.
            switch (AntDirection)
            {
                case Direction.Left:
                    AntLocation.X--;
                    break;
                case Direction.Up:
                    AntLocation.Y--;
                    break;
                case Direction.Right:
                    AntLocation.X++;
                    break;
                case Direction.Down:
                    AntLocation.Y++;
                    break;
            }

            // Redraw.
            worldPictureBox.Refresh();
            TurnNumber++;
            turnLabel.Text = TurnNumber.ToString();
        }
    }
}
