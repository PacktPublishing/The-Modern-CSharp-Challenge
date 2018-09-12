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

namespace Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The size of a square.
        private const int Wid = 8;

        // The size of the world.
        private int GridWid, GridHgt;

        // The PictureBox dimensions.
        private int Dxmax, Dymax;

        // The world.
        private bool[,] World = null;

        // The turn number.
        private int TurnNumber = 0;

        // True if we should wrap squares  across the world's edges.
        private bool WrapEdges = true;

        // Make the World array and get geometry values.
        private void Form1_Load(object sender, EventArgs e)
        {
            GridWid = worldPictureBox.ClientSize.Width / Wid;
            GridHgt = worldPictureBox.ClientSize.Height / Wid;
            World = new bool[GridWid, GridHgt];

            Dxmax = worldPictureBox.ClientSize.Width;
            Dymax = worldPictureBox.ClientSize.Height;
        }

        // Toggle a square.
        private void worldPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Find the point in world coordinates.
            int x = e.Location.X / Wid;
            int y = e.Location.Y / Wid;
            if ((x >= GridWid) || (y >= GridHgt)) return;

            // Toggle the square clicked.
            World[x, y] = !World[x, y];

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
                for (int x = 0; x <= GridWid; x++)
                    e.Graphics.DrawLine(pen, x * Wid, 0, x * Wid, Dymax);
                for (int y = 0; y <= GridHgt; y++)
                    e.Graphics.DrawLine(pen, 0, y * Wid, Dxmax, y * Wid);
            }

            // Draw the squares.
            for (int x = 0; x < GridWid; x++)
            {
                for (int y = 0; y < GridHgt; y++)
                {
                    if (World[x, y])
                    {
                        e.Graphics.FillRectangle(Brushes.Black,
                            x * Wid, y * Wid, Wid - 1, Wid - 1);
                    }
                }
            }
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
            World = new bool[GridWid, GridHgt];
            worldPictureBox.Refresh();
        }

        // Load a pattern defined by strings of 0s and 1s.
        private void LoadPattern(string[] pattern)
        {
            World = new bool[GridWid, GridHgt];
            int x = (GridWid - pattern[0].Length) / 2;
            int y = (GridHgt - pattern.Length) / 2;
            for (int iy = 0; iy < pattern.Length; iy++)
                for (int ix = 0; ix < pattern[iy].Length; ix++)
                    World[x + ix, y + iy] = (pattern[iy][ix] == '1');

            TurnNumber = 0;
            turnLabel.Text = "0";
            worldPictureBox.Refresh();
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "11",
                "11",
            };
            LoadPattern(pattern);
        }

        private void beehiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "0110",
                "1001",
                "0110",
            };
            LoadPattern(pattern);
        }

        private void loafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "0110",
                "1001",
                "0101",
                "0010",
            };
            LoadPattern(pattern);
        }

        private void boatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "110",
                "101",
                "010",
            };
            LoadPattern(pattern);
        }

        private void tubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "010",
                "101",
                "010",
            };
            LoadPattern(pattern);
        }

        private void blinkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "010",
                "010",
                "010",
            };
            LoadPattern(pattern);
        }

        private void stoplightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "010",
                "010",
                "010",
                "000",
                "000",
                "111",
                "000",
                "000",
                "010",
                "010",
                "010",
            };
            LoadPattern(pattern);
        }

        private void toadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "0111",
                "1110",
            };
            LoadPattern(pattern);
        }

        private void beaconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "1100",
                "1100",
                "0011",
                "0011",
            };
            LoadPattern(pattern);
        }

        private void pulsarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "0011100011100",
                "0000000000000",
                "1000010100001",
                "1000010100001",
                "1000010100001",
                "0011100011100",
                "0000000000000",
                "0011100011100",
                "1000010100001",
                "1000010100001",
                "1000010100001",
                "0000000000000",
                "0011100011100",
            };
            LoadPattern(pattern);
        }

        private void pentadecathlonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "01110",
                "10001",
                "10001",
                "01110",
                "00000",
                "00000",
                "00000",
                "00000",
                "01110",
                "10001",
                "10001",
                "01110",
            };
            LoadPattern(pattern);
        }

        private void gliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "010",
                "001",
                "111",
            };
            LoadPattern(pattern);
        }

        private void lightweightSpaceshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "10010",
                "00001",
                "10001",
                "01111",
            };
            LoadPattern(pattern);
        }

        private void rPentominoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "011",
                "110",
                "010",
            };
            LoadPattern(pattern);
        }

        private void diehardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "00000010",
                "11000000",
                "01000111",
            };
            LoadPattern(pattern);
        }

        private void acornToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "0100000",
                "0001000",
                "1100111",
            };
            LoadPattern(pattern);
        }

        private void gosperGliderGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "000000000000000000000000100000000000",
                "000000000000000000000010100000000000",
                "000000000000110000001100000000000011",
                "000000000001000100001100000000000011",
                "110000000010000010001100000000000000",
                "110000000010001011000010100000000000",
                "000000000010000010000000100000000000",
                "000000000001000100000000000000000000",
                "000000000000110000000000000000000000",
            };
            LoadPattern(pattern);
        }

        private void pattern1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "00000010",
                "00001011",
                "00001010",
                "00001000",
                "00100000",
                "10100000",
            };
            LoadPattern(pattern);
        }

        private void pattern2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "11101",
                "10000",
                "00011",
                "01101",
                "10101",
            };
            LoadPattern(pattern);
        }

        private void pattern3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] pattern =
            {
                "111111110111110001110000001111111011111",
            };
            LoadPattern(pattern);
        }

        // Toggle the wrap style.
        private void wrapEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WrapEdges = !WrapEdges;
        }

        // Make a purely random pattern.
        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int y = 0; y < GridHgt; y++)
            {
                for (int x = 0; x < GridWid; x++)
                {
                    World[x, y] = (rand.Next(0, 2) == 1);
                }
            }
            worldPictureBox.Refresh();
        }

        private void resetCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnNumber = 0;
            turnLabel.Text = "0";
        }

        // Move objects.
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // See how many neighbors each squares has.
            int[,] numNeighbors = new int[GridWid, GridHgt];
            for (int y = 0; y < GridHgt; y++)
            {
                for (int x = 0; x < GridWid; x++)
                {
                    // See if this square is occupied.
                    if (World[x, y])
                    {
                        // Add this square to its neighbors' counts.
                        for (int dx = -1; dx <= 1; dx++)
                            for (int dy = -1; dy <= 1; dy++)
                                if ((dx != 0) || (dy != 0))
                                {
                                    if (WrapEdges)
                                    {
                                        // Wrap style.
                                        int nx = (x + dx + GridWid) % GridWid;
                                        int ny = (y + dy + GridHgt) % GridHgt;
                                        numNeighbors[nx, ny]++;
                                    }
                                    else
                                    {
                                        // Discard style.
                                        int nx = x + dx;
                                        int ny = y + dy;
                                        if ((nx >= 0) && (nx < GridWid) &&
                                            (ny >= 0) && (ny < GridHgt))
                                                numNeighbors[nx, ny]++;
                                    }
                                }
                    }
                }
            }

            // Repopulate the world.
            bool changed = false;
            for (int y = 0; y < GridHgt; y++)
            {
                for (int x = 0; x < GridWid; x++)
                {
                    // See if the square is currently populated.
                    bool value = World[x, y];
                    if (value)
                    {
                        // Currently populated. See if it survives.
                        if ((numNeighbors[x, y] < 2) ||
                            (numNeighbors[x, y] > 3))
                                value = false;
                    }
                    else
                    {
                        // Currently unpopulated. See if we should populate it.
                        if (numNeighbors[x, y] == 3)
                            value = true;
                    }
                    if (World[x, y] != value) changed = true;
                    World[x, y] = value;
                }
            }

            // If nothing changed, stop.
            if (!changed) startToolStripMenuItem_Click(null, null);

            // Redraw.
            worldPictureBox.Refresh();
            TurnNumber++;
            turnLabel.Text = TurnNumber.ToString();
        }
    }
}
