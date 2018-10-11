using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// In the Add Reference dialog's COM tab, add a reference to Windows Media Player

using System.Drawing.Drawing2D;
using System.Media;             // SoundPlayer.
using System.Windows.Input;     // Keyboard.
using WMPLib;                   // WindowsMediaPlayer.

// Explosion image (CC0 license): commons.wikimedia.org/wiki/File:Explosion-417894_icon.svg
// Pew sound (CC license): freesound.org/people/Mattix/sounds/414885/
// Explosion sound (CC license): freesound.org/people/JeffSheep/sounds/399303/
// Pop sound (CC license): freesound.org/people/kwahmah_02/sounds/260614/
// Tada sound (CC license): freesound.org/people/Robinhood76/sounds/62176/

// In Solution Explorer, for the file boom.mp3, set:
//      Build Action = Content
//      Copy to Output Directory = Copy if newer

// Add references to:
//      PresentationCore
//      WindowsBase

namespace SpaceForce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sounds.
        private SoundPlayer PewSound, PopSound, TadaSound;
        private WindowsMediaPlayer BoomSound;

        // The sprites.
        private Ship TheShip = null;
        private List<Sprite> Bubbles = new List<Sprite>();
        private List<Sprite> Bullets = new List<Sprite>();

        // The PictureBox's client area. (For convenience.)
        private Rectangle SpaceBounds;

        // The last time the user fired.
        private DateTime LastShot = DateTime.Now;

        // True when we are not playing.
        private bool GameOver = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            SpaceBounds = spacePictureBox.ClientRectangle;
            PewSound = new SoundPlayer(Properties.Resources.pew);
            PopSound = new SoundPlayer(Properties.Resources.pop);
            TadaSound = new SoundPlayer(Properties.Resources.tada);
            BoomSound = new WindowsMediaPlayer();
            BoomSound.settings.autoStart = false;
            BoomSound.URL = "boom.mp3";
            BoomSound.settings.volume = 0;
            BoomSound.controls.play();

            TheShip = new Ship(spacePictureBox.ClientRectangle);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Start or stop.
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "&Start")
                StartGame();
            else
                StopGame();
        }

        // Start the game.
        private void StartGame()
        {
            startToolStripMenuItem.Text = "&Stop";
            GameOver = false;

            BoomSound.controls.stop();
            BoomSound.settings.volume = 50;

            // Make the ship.
            TheShip = new Ship(SpaceBounds);

            // Make bubbles.
            Bubbles = new List<Sprite>();
            for (int i = 0; i < 10; i++)
            {
                Bubbles.Add(Bubble.RandomBubble(spacePictureBox.ClientRectangle));
            }

            // Draw.
            spacePictureBox.Refresh();

            // Start the timer.
            moveTimer.Enabled = true;
        }

        // Stop the game.
        private void StopGame()
        {
            // Stop the timer.
            moveTimer.Enabled = false;
            startToolStripMenuItem.Text = "&Start";
            GameOver = true;
        }

        // Draw the scene.
        private void spacePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(spacePictureBox.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (!moveTimer.Enabled) return;

            // Draw the sprites.
            foreach (Sprite bubble in Bubbles) bubble.Draw(e.Graphics);
            foreach (Sprite bullet in Bullets) bullet.Draw(e.Graphics);
            TheShip.Draw(e.Graphics);
        }

        // Make a move.
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // See if any keys are pressed.
            ProcessKeys();

            // Move the sprites.
            if (TheShip != null) TheShip.Move(SpaceBounds);
            foreach (Sprite bubble in Bubbles) bubble.Move(SpaceBounds);
            foreach (Sprite bullet in Bullets) bullet.Move(SpaceBounds, false);

            // Check for out of bounds bullets.
            foreach (Bubble bullet in Bullets)
            {
                if (bullet.IsOutOfBounds(SpaceBounds))
                    bullet.IsDestroyed = true;
            }

            // Check for bullet/bubble collisions.
            bool hadPop = false;
            foreach (Bubble bullet in Bullets)
            {
                if (bullet.IsDestroyed) continue;
                foreach (Bubble bubble in Bubbles)
                {
                    if (bubble.IsDestroyed) continue;

                    if (bullet.IntersectsWith(bubble))
                    {
                        // Destroy them both.
                        bullet.IsDestroyed = true;
                        bubble.IsDestroyed = true;
                        hadPop = true;
                        break;
                    }
                }
            }

            // If a bubble popped, play the pop sound.
            if (hadPop) PopSound.Play();

            // Check for bubble/ship collisions.
            if (!TheShip.IsDestroyed)
            {
                foreach (Bubble bubble in Bubbles)
                {
                    if (!bubble.IsDestroyed && TheShip.IntersectsWith(bubble))
                    {
                        // Destroy them both.
                        TheShip.IsDestroyed = true;
                        TheShip.Bounds.Inflate(20, 20);
                        bubble.IsDestroyed = true;
                        BoomSound.controls.play();
                        break;
                    }
                }
            }

            // Remove destroyed bubbles and bullets.
            Bullets = Bullets.Where(x => !x.IsDestroyed).ToList();
            Bubbles = Bubbles.Where(x => !x.IsDestroyed).ToList();

            // See if the player won.
            if (!GameOver &&
                !TheShip.IsDestroyed &&
                Bubbles.Count == 0)
            {
                GameOver = true;
                TadaSound.Play();
            }

            // Draw.
            spacePictureBox.Refresh();
        }

        // Take action of the user has pressed an action key.
        private void ProcessKeys()
        {
            // Do nothing if the ship has been destroyed.
            if (TheShip.IsDestroyed) return;

            // Require at least 250ms between shots.
            const int msPerShot= 250;

            // Shoot.
            if (Keyboard.IsKeyDown(Key.Space))
            {
                // Make sure the required time has elapsed since the last shot.
                TimeSpan timePassed = DateTime.Now - LastShot;
                if (timePassed.TotalMilliseconds >= msPerShot)
                {
                    Shoot();
                }
            }

            // Accelerate.
            if (Keyboard.IsKeyDown(Key.Up)) TheShip.Accelerate();

            // Turn left.
            if (Keyboard.IsKeyDown(Key.Left)) TheShip.TurnLeft();

            // Turn right.
            if (Keyboard.IsKeyDown(Key.Right)) TheShip.TurnRight();
        }

        // Pew!
        private void Shoot()
        {
            PewSound.Play();
            LastShot = DateTime.Now;

            // Launch a bullet.
            Bullets.Add(TheShip.MakeBullet());
        }
    }
}
