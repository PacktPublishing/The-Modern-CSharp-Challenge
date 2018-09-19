using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add a reference to System.Numerics.
using System.Numerics;

namespace FindPrimes
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
                if (BigInteger.ModPow(n, p - 1, p) != 1) return 0;   // Definitely not prime.
            }

            // Probably prime.
            return 1.0 - 1.0 / Math.Pow(2, numTests);
        }

        // Find a prime at least as large a startNumber and
        // with at least the given probability of being prime.
        // Return the number, probability, and number of tests performed.
        public static BigInteger FindNextPrime(this BigInteger startNumber, double desiredProb, out double primeProb, out int numTests)
        {
            // Make sure the start number is odd.
            if ((startNumber != 2) && (startNumber % 2 == 0)) startNumber++;

            // Calculate the number of tests we need to run to achieve the desired probability.
            numTests = (int)Math.Log(1.0 / (1.0 - desiredProb), 2) + 1;

            // Test values until we find a prime.
            for (BigInteger p = startNumber; ; p += 2)
            {
                primeProb = p.ProbabilityIsPrime(numTests);
                if (primeProb > 0.1) return p;
            }
        }
    }
}
