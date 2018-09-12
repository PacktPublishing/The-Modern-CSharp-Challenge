using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SharksAndFish
{
    class Ocean
    {
        private static Random Rand = new Random();

        public Animal[,] Grid { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Bitmap Bitmap = null;

        public List<Fish> Fishes = new List<Fish>();
        public int FishBreedingTime { get; set; }
        public int FishEnergyValue { get; set; }

        public List<Shark> Sharks = new List<Shark>();
        public int SharkEnergyLoss { get; set; }
        public int SharkSplitEnergy { get; set; }

        public Ocean(int width, int height,
            int numFish, int fishBreedingTime, int fishEnergyValue,
            int numSharks, int sharkEnergyLoss, int sharkSplitEnergy)
        {
            Width = width;
            Height = height;
            Grid = new Animal[Width, Height];
            Bitmap = new Bitmap(Width, Height);
            using (Graphics gr = Graphics.FromImage(Bitmap))
            {
                gr.Clear(Color.Black);
            }

            FishBreedingTime = fishBreedingTime;
            FishEnergyValue = fishEnergyValue;

            SharkEnergyLoss = sharkEnergyLoss;
            SharkSplitEnergy = sharkSplitEnergy;

            MakeFish(numFish);
            MakeSharks(numSharks);
        }

        // Make the fish.
        private void MakeFish(int numFish)
        {
            for (int i = 0; i < numFish; i++)
            {
                Fishes.Add(new Fish(this, FishBreedingTime));
            }
        }

        // Make the sharks.
        private void MakeSharks(int numSharks)
        {
            int minEnergy = (int)(SharkSplitEnergy * 0.25);
            int maxEnergy = (int)(SharkSplitEnergy * 0.75 + 1);
            for (int i = 0; i < numSharks; i++)
            {
                Sharks.Add(new Shark(this, Rand.Next(minEnergy, maxEnergy)));
            }
        }

        // Find neighboring locations where an animal could move.
        public List<Point> FreeSpots(int x, int y, bool ignoreFish = false)
        {
            Point[] points =
            {
                new Point((x - 1 + Width) % Width, y),
                new Point((x + 1) % Width, y),
                new Point(x, (y - 1 + Height) % Height),
                new Point(x, (y + 1) % Height),
            };
            List<Point> spots = new List<Point>();
            foreach (Point p in points)
            {
                if ((Grid[p.X, p.Y] == null) ||
                    (ignoreFish && (Grid[p.X, p.Y] is Fish)))
                    spots.Add(p);
            }
            return spots;
        }

        // Pick a random point from the list.
        public Point PickSpot(List<Point> spots)
        {
            return spots.Random();
        }

        // Move the fish and sharks.
        public void Move()
        {
            // Make a copy of the Fishes list so we can modify the original.
            List<Fish> tempFishes = new List<Fish>(Fishes);

            // Move the fish.
            foreach (Fish fish in tempFishes) fish.Move();

            // Make a copy of the Sharks list so we can modify the original.
            List<Shark> tempSharks = new List<Shark>(Sharks);

            // Move the Shark.
            foreach (Shark Shark in tempSharks) Shark.Move();
        }
    }
}
