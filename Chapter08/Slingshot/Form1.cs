#define DRAW_CIRCLE

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

namespace Slingshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Slingshot geometry.
        private const int GroundThickness = 30;
        private Rectangle GroundRect;
        private PointF[] BasePoints = null;
        private int BaseThickness = 6;
        private const int BaseX = 50;
        private const int BaseHgt = 30;
        private const int CrossWid = 10;
        private const int CrossHgt = 25;
        private PointF CrossEnd1, CrossEnd2, CrossCenter;

        // Sling geometry.
        private const float MaxR = 50;

        // True when the user is positioning the shot.
        private bool Dragging = false;

        // Shot geometry.
        private const int ShotR = 5;
        private PointF ShotPosition;
        private float ShotVx, ShotVy;
        private const float VelocityScale = 0.5f;

        // Acceleration due to gravity.
        private const float AccY = 3.2f * VelocityScale;

        // Initialize the slingshot and ground positions.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            // Define the ground for drawing.
            int groundY = scenePictureBox.ClientSize.Height - GroundThickness;
            GroundRect = new Rectangle(0, groundY,
                scenePictureBox.ClientSize.Width,
                scenePictureBox.ClientSize.Height - groundY);

            // Define the slingshot for drawing.
            List<PointF> pointList = new List<PointF>();
            PointF point = new PointF(BaseX, groundY);
            pointList.Add(point);
            point.Y -= BaseHgt;
            pointList.Add(point);
            point.X -= CrossWid;
            point.Y += CrossWid;
            pointList.Add(point);
            point.Y -= CrossHgt;
            pointList.Add(point);
            point.Y += CrossHgt;
            pointList.Add(point);
            point.X += 1.5f * CrossWid;
            point.Y -= 1.5f * CrossWid;
            pointList.Add(point);
            point.Y -= CrossHgt;
            pointList.Add(point);
            BasePoints = pointList.ToArray();
            CrossEnd1 = BasePoints[3];
            CrossEnd2 = BasePoints[6];
            CrossCenter = new PointF(
                (CrossEnd1.X + CrossEnd2.X) / 2,
                (CrossEnd1.Y + CrossEnd2.Y) / 2);

            // Place the shot at the center of the slingshot.
            ShotPosition = CrossCenter;
        }

        // Let the user position the slingshot's end.
        private void scenePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Don't allow a drag if a turn is in progress.
            if (moveTimer.Enabled) return;

            // Don't drag unless the mouse is over the shot.
            if (Distance(e.Location, ShotPosition) > ShotR) return;

            // Start dragging.
            Dragging = true;
            ShotPosition = e.Location;
            scenePictureBox.Refresh();
        }

        // Return the distance between two points.
        private double Distance(PointF point1, PointF point2)
        {
            float dx = point1.X - point2.X;
            float dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Continue dragging the shot.
        private void scenePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Dragging) return;

            // See if we're inside of the allowed circle.
            double dist = Distance(e.Location, CrossCenter);
            if (dist <= MaxR)
            {
                // Just move the shot.
                ShotPosition = e.Location;
            }
            else
            {
                // Adjust the shot position so it's inside the circle.
                float dx = (e.Location.X - CrossCenter.X) * MaxR / (float)dist;
                float dy = (e.Location.Y - CrossCenter.Y) * MaxR / (float)dist;
                ShotPosition = new PointF(
                    CrossCenter.X + dx,
                    CrossCenter.Y + dy);
            }
            scenePictureBox.Refresh();
        }

        // Stop dragging and launch the shot.
        private void scenePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Dragging) return;
            Dragging = false;

            // Get the shot's horizontal and vertical velocity components.
            ShotVx = VelocityScale * (CrossCenter.X - ShotPosition.X);
            ShotVy = VelocityScale * (CrossCenter.Y - ShotPosition.Y);

            // Start the timer.
            moveTimer.Enabled = true;
        }

        // Draw the scene.
        private void scenePictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Clear and draw the ground.
            e.Graphics.Clear(scenePictureBox.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.SandyBrown, GroundRect);

            // Draw the slingshot.
            using (Pen pen = new Pen(Color.SaddleBrown, BaseThickness))
            {
                pen.LineJoin = LineJoin.Round;
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                e.Graphics.DrawLines(pen, BasePoints);
            }

#if DRAW_CIRCLE
            // Optional: Draw a circle showing allowed shot positions.
            using (Pen pen = new Pen(Color.Green, 0))
            {
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new float[] { 1, 4 };
                RectangleF circleRect = MakeRect(CrossCenter, MaxR);
                e.Graphics.DrawEllipse(pen, circleRect);
            }
#endif

            // Sling and shot.
            using (Pen pen = new Pen(Color.Red, 2))
            {
                // Only draw the sling if no shot is in progress.
                if (!moveTimer.Enabled) e.Graphics.DrawLine(pen, ShotPosition, CrossEnd2);

                RectangleF shotRect = MakeRect(ShotPosition, ShotR);
                e.Graphics.FillEllipse(Brushes.Black, shotRect);

                if (!moveTimer.Enabled) e.Graphics.DrawLine(pen, ShotPosition, CrossEnd1);
            }
        }

        // Move the shot.
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // Update the velocity components.
            ShotVy += AccY;

            // Calculate the shot's new position.
            ShotPosition.X += ShotVx;
            ShotPosition.Y += ShotVy;

            // See if the shot has left the scene.
            if ((ShotPosition.X < 0) ||
                (ShotPosition.X > scenePictureBox.ClientSize.Width) ||
                (ShotPosition.Y > GroundRect.Top))
            {
                // Stop.
                moveTimer.Enabled = false;

                // Reset the shot.
                ShotPosition = CrossCenter;
            }

            // Redraw.
            scenePictureBox.Refresh();
        }

        // Return a rectangle centered at the point.
        private RectangleF MakeRect(PointF center, float radius)
        {
            return new RectangleF(
                center.X - radius, center.Y - radius,
                2 * radius, 2 * radius);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Reset the hits and misses.
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveTimer.Enabled = false;
            ShotPosition = CrossCenter;
            scenePictureBox.Refresh();
        }
    }
}
