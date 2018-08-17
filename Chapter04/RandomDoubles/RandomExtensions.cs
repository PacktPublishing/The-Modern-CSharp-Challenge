using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDoubles
{
    public static class RandomExtensions
    {
        // A Random objects shared by all extensions.
        private static Random Rand = new Random();

        // Return a double between minValue and maxValue.
        public static double NextDouble(this Random rand, double minValue, double maxValue)
        {
            return minValue + Rand.NextDouble() * (maxValue - minValue);
        }
    }
}
