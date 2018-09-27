using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add a reference to System.Numerics.
using System.Numerics;

namespace PrimalityTesting
{
    public static class PrimeExtensions
    {
        // Used to pick random N.
        private static Random Rand = new Random();

        // Return the probability that the number is prime.
        public static double ProbabilityIsPrime(this BigInteger p, int numTests)
        {
            // Calculate the largest value we should generate randomly.
            int maxValue = int.MaxValue;
            if (p - 1 < maxValue) maxValue = (int)(p - 1);

            for (int test = 0; test < numTests; test++)
            {
                int n = Rand.Next(2, maxValue);
                if (BigInteger.ModPow(n, p - 1, p) != 1) return 0;  // Definitely not prime.
            }

            // Probably prime.
            return 1.0 - 1.0 / Math.Pow(2, numTests);
        }
    }
}
