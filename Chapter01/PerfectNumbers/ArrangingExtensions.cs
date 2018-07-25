using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    public static class ArrangingExtensions
    {
        #region Permutations

        // Find permutations containing the desired number of items.
        public static List<List<T>> Permutations<T>(this T[] values, int numPerGroup)
        {
            int numValues = values.Count();
            bool[] used = new bool[numValues];
            List<T> currentSolution = new List<T>();
            return FindPermutations(values, numPerGroup, currentSolution, used, numValues);
        }

        // Find permutations that include the current solution.
        private static List<List<T>> FindPermutations<T>(T[] values, int numPerGroup,
            List<T> currentSolution, bool[] used, int numValues)
        {
            List<List<T>> results = new List<List<T>>();

            // If this solution has the desired length, return it.
            if (currentSolution.Count() == numPerGroup)
            {
                // Make a copy because currentSolution will change over time.
                List<T> copy = new List<T>(currentSolution);
                results.Add(copy);
                return results;
            }

            // Try adding other values to the solution.
            for (int i = 0; i < numValues; i++)
            {
                // See if value[i] is in the solution yet.
                if (!used[i])
                {
                    // Try adding this value.
                    used[i] = true;
                    currentSolution.Add(values[i]);

                    // Recursively look for solutions that have values[i] added.
                    List<List<T>> newResults =
                        FindPermutations(values, numPerGroup, currentSolution, used,
                            numValues);
                    results.AddRange(newResults);

                    // Remove values[i].
                    used[i] = false;
                    currentSolution.RemoveAt(currentSolution.Count() - 1);
                }
            }

            return results;
        }

        // Find permutations containing any number of items.
        public static List<List<T>> Permutations<T>(this T[] values)
        {
            List<List<T>> results = new List<List<T>>();

            // Get permutations of all lengths.
            for (int i = 1; i <= values.Count(); i++)
                results.AddRange(values.Permutations(i));

            return results;
        }

        #endregion Permutations

        #region Combinations

        // Find combinations containing the desired number of items.
        public static List<List<T>> Combinations<T>(this T[] values, int numPerGroup)
        {
            int numValues = values.Count();
            bool[] used = new bool[numValues];
            List<T> currentSolution = new List<T>();
            return FindCombinations(values, numPerGroup, currentSolution, used, 0, numValues);
        }

        // Find Combinations that include the current solution.
        private static List<List<T>> FindCombinations<T>(T[] values, int numPerGroup,
            List<T> currentSolution, bool[] used, int firstIndex, int numValues)
        {
            List<List<T>> results = new List<List<T>>();

            // If this solution has the desired length, return it.
            if (currentSolution.Count() == numPerGroup)
            {
                // Make a copy because currentSolution will change over time.
                List<T> copy = new List<T>(currentSolution);
                results.Add(copy);
                return results;
            }

            // Try adding other values to the solution.
            for (int i = firstIndex; i < numValues; i++)
            {
                // See if value[i] is in the solution yet.
                if (!used[i])
                {
                    // Try adding this value.
                    used[i] = true;
                    currentSolution.Add(values[i]);

                    // Recursively look for solutions that have values[i] added.
                    List<List<T>> newResults =
                        FindCombinations(values, numPerGroup, currentSolution,
                            used, i + 1, numValues);
                    results.AddRange(newResults);

                    // Remove values[i].
                    used[i] = false;
                    currentSolution.RemoveAt(currentSolution.Count() - 1);
                }
            }

            return results;
        }

        // Find combinations containing any number of items.
        public static List<List<T>> Combinations<T>(this T[] values)
        {
            List<List<T>> results = new List<List<T>>();

            // Get combinations of all lengths.
            for (int i = 1; i <= values.Count(); i++)
                results.AddRange(values.Combinations(i));

            return results;
        }

        #endregion Combinations
    }
}
