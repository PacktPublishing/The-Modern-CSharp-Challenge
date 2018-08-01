using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloIntegration
{
    public static class RandomExtensions
    {
        // Return a random double between min and max.
        public static double NextDouble(this Random rand, double min, double max)
        {
            return min + rand.NextDouble() * (max - min);
        }
    }
}
