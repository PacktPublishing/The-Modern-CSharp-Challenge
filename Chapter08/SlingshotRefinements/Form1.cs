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

// Fire image: pixabay.com/en/fire-flame-burning-hot-red-yellow-48870/
// House image: pixabay.com/en/home-house-building-architecture-158089/
// Explosion sound (CC license): freesound.org/people/JeffSheep/sounds/399303/
// Splat sound (CC license): freesound.org/people/Flasher21/sounds/87535/
// Boing sound (CC license): freesound.org/people/juskiddink/sounds/140867/

// In Solution Explorer, for the file boom.mp3, set:
//      Build Action = Content
//      Copy to Output Directory = Copy if newer

// In the Add Reference dialog's COM tab, add a reference to Windows Media Player

using System.Drawing.Drawing2D;
using System.Media;
using WMPLib;			        // WindowsMediaPlayer.

namespace SlingshotRefinements
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

        // Past hits and misses.
        private List<RectangleF> Misses = new List<RectangleF>();
        private List<RectangleF> Hits = new List<RectangleF>();

        // House geometry.
        private RectangleF HouseRect, TargetRect;

        // Fire geometry.
        private float FireWidth, FireHeight;

        // Sounds.
        private SoundPlayer ShotSound, SplatSound;
        private WindowsMediaPlayer BoomSound;

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

            // Position the house.
            PositionHouse();

            // Get the fire dimensions.
            FireWidth = HouseRect.Width;
            float fireScale = HouseRect.Width / Properties.Resources.flames.Width;
            FireHeight = (int)(Properties.Resources.flames.Height * fireScale);

            // Load the shot and explosion sound players.
            ShotSound = new SoundPlayer(Properties.Resources.boing);
            SplatSound = new SoundPlayer(Properties.Resources.splat);
            BoomSound = new WindowsMediaPlayer();
            BoomSound.settings.autoStart = false;
            BoomSound.URL = "boom.mp3";

            // Play the Boom sound at zero volume to pre-load it.
            BoomSound.settings.volume = 0;
            BoomSound.controls.play();
        }

        // Place the house in a random position.
        private void PositionHouse()
        {
            // See how big to make the house on the screen.
            int houseWidth = 50;
            float scale = (float)houseWidth / Properties.Resources.house.Width;
            int houseHeight = (int)(Properties.Resources.house.Height * scale);

            Random rand = new Random();
            int sceneWid = scenePictureBox.ClientSize.Width;
            float x = rand.Next((int)(BaseX + MaxR), sceneWid - houseWidth);
            float y = GroundRect.Top - 0.85f * houseHeight;
            HouseRect = new RectangleF(x, y, houseWidth, houseHeight);

            // Make a smaller target rectangle.
            TargetRect = HouseRect;
            TargetRect.Inflate(-houseWidth * 0.2f, -houseHeight * 0.1f);
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
            BoomSound.controls.stop();
            BoomSound.settings.volume = 50;

            // Get the shot's horizontal and vertical velocity components.
            ShotVx = VelocityScale * (CrossCenter.X - ShotPosition.X);
            ShotVy = VelocityScale * (CrossCenter.Y - ShotPosition.Y);

            // Play the shot sound.
            ShotSound.Play();

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

            // Past hits.
            foreach (RectangleF hitRect in Hits)
            {
                e.Graphics.DrawImage(Properties.Resources.flames, hitRect);
            }

            // Past misses.
            foreach (RectangleF missRect in Misses)
            {
                e.Graphics.FillEllipse(Brushes.Black, missRect);
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

            // House.
            e.Graphics.DrawImage(Properties.Resources.house, HouseRect);
        }

        // Move the shot.
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // Update the velocity components.
            ShotVy += AccY;

            // Calculte the shot's new position.
            ShotPosition.X += ShotVx;
            ShotPosition.Y += ShotVy;

            // See if we hit the target.
            RectangleF shotRect = MakeRect(ShotPosition, ShotR);
            if (shotRect.IntersectsWith(TargetRect))
            {
                // We hit it. Stop.
                moveTimer.Enabled = false;

                // Play the explosion sound.
                BoomSound.controls.play();

                // Save the hit spot.
                RectangleF hitRect = new RectangleF(
                    HouseRect.X, HouseRect.Bottom - FireHeight,
                    FireWidth, FireHeight);
                Hits.Add(hitRect);

                // Move the house.
                PositionHouse();

                // Reset the shot.
                ShotPosition = CrossCenter;
            }
            else if ((ShotPosition.X < 0) ||
                (ShotPosition.X > scenePictureBox.ClientSize.Width) ||
                (ShotPosition.Y > GroundRect.Top))
            {
                // The shot has left the scene. Stop.
                moveTimer.Enabled = false;

                // Save this position as a miss.
                if ((ShotPosition.X > 0) &&
                    (ShotPosition.X < scenePictureBox.ClientSize.Width))
                {
                    // Adjust the shot so it sits on the ground.
                    float dy = ShotPosition.Y - GroundRect.Top;
                    float dx = ShotVx * dy / ShotVy;
                    ShotPosition.X -= dx;
                    ShotPosition.Y -= dy;

                    // Play the splat sound.
                    SplatSound.Play();

                    // Save the location where the shot hit the ground.
                    Misses.Add(MakeRect(ShotPosition, ShotR));
                }

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
            Hits = new List<RectangleF>();
            Misses = new List<RectangleF>();
            PositionHouse();
            ShotPosition = CrossCenter;
            scenePictureBox.Refresh();
        }
    }
}
