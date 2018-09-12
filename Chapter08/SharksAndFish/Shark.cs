using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SharksAndFish
{
    class Shark : Animal
    {
        public int Energy { get; set; }
        public static Color Color = Color.Red;

        public Shark(Ocean ocean, int energy, int x, int y)
            : base(ocean, Color, x, y)
        {
            Energy = energy;
        }
        public Shark(Ocean ocean, int energy)
            : this(ocean, energy,
                  Rand.Next(ocean.Width), Rand.Next(ocean.Height))
        {
        }

        public override void Move()
        {
            // Lose energy.
            Energy -= Ocean.SharkEnergyLoss;
            if (Energy == 0)
            {
                // Die.
                Ocean.Bitmap.SetPixel(X, Y, Color.Black);
                Ocean.Grid[X, Y] = null;
                Ocean.Sharks.Remove(this);
                return;
            }

            // Look for a free spot.
            List<Point> spots = Ocean.FreeSpots(X, Y, true);
            if (spots.Count == 0) return;

            // Move.
            Ocean.Bitmap.SetPixel(X, Y, Color.Black);
            Ocean.Grid[X, Y] = null;

            // See if the new spot contains food.
            Point moveTo = spots.Random();
            if (Ocean.Grid[moveTo.X, moveTo.Y] is Fish)
            {
                // Eat it.
                Energy += Ocean.FishEnergyValue;
                Fish fish = Ocean.Grid[moveTo.X, moveTo.Y] as Fish;
                Ocean.Fishes.Remove(fish);
            }

            // Move to the new spot.
            X = moveTo.X;
            Y = moveTo.Y;
            Ocean.Bitmap.SetPixel(X, Y, Fish.Color);
            Ocean.Grid[X, Y] = this;

            // Breed.
            Split();
        }

        // See if we should breed.
        private void Split()
        {
            if (Energy < Ocean.SharkSplitEnergy) return;

            // Split.
            Energy /= 2;

            // Position a child.
            List<Point> spots = Ocean.FreeSpots(X, Y, false);
            if (spots.Count == 0) return;

            Point childSpot = spots.Random();
            Ocean.Sharks.Add(new Shark(Ocean, Energy, childSpot.X, childSpot.Y));
        }
    }
}
