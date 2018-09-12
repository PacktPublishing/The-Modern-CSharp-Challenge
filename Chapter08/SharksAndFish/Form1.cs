using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharksAndFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ocean Ocean = null;
        private int Turn = 0;

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "Start")
                StartSimulation();
            else
                StopSimulation();
        }
        private void StartSimulation()
        {
            startStopButton.Text = "Stop";
            Refresh();

            int width = int.Parse(gridWidthTextBox.Text);
            int height = int.Parse(gridHeightTextBox.Text);
            int numFish = int.Parse(numFishTextBox.Text);
            int fishBreedingTime = int.Parse(fishBreedingTimeTextBox.Text);
            int fishEnergyValue = int.Parse(fishEnergyValueTextBox.Text);

            int numSharks = int.Parse(numSharksTextBox.Text);
            int sharkEnergyLoss = int.Parse(sharkEnergyLossTextBox.Text);
            int sharkSplitEnergy = int.Parse(sharkSplitEnergyTextBox.Text);

            Ocean = new Ocean(width, height,
                numFish, fishBreedingTime, fishEnergyValue,
                numSharks, sharkEnergyLoss, sharkSplitEnergy);
            oceanPictureBox.Image = Ocean.Bitmap;
            this.ClientSize =
                new Size(ClientSize.Width, oceanPictureBox.Bottom + 12);

            Turn = 0;
            turnTextbox.Text = Turn.ToString();
            currentNumFishTextBox.Text = Ocean.Fishes.Count.ToString();
            currentNumSharksTextBox.Text = Ocean.Sharks.Count.ToString();

            turnTimer.Interval = int.Parse(msPerTurnTextBox.Text);
            turnTimer.Enabled = true;
        }

        private void StopSimulation()
        {
            turnTimer.Enabled = false;
            startStopButton.Text = "Start";
        }

        // Move the sharks and fish.
        private void turnTimer_Tick(object sender, EventArgs e)
        {
            Ocean.Move();
            Turn++;
            turnTextbox.Text = Turn.ToString();
            currentNumFishTextBox.Text = Ocean.Fishes.Count.ToString();
            currentNumSharksTextBox.Text = Ocean.Sharks.Count.ToString();
            Refresh();
        }
    }
}
