using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace ParallelPrimeTuples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Find tuples.
        private void goButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            iterativeTextBox.Clear();
            parallelTextBox.Clear();
            numGroupsLabel.Text = "";
            Cursor = Cursors.WaitCursor;
            Refresh();

            int max = int.Parse(maxTextBox.Text);
            int spacing = int.Parse(spacingTextBox.Text);
            int numPerGroup = int.Parse(numPerGroupTextBox.Text);

            // Make a sieve.
            bool[] isPrime = MakeEulersSieve(max);

            Stopwatch watch = new Stopwatch();

            // Look for groups of primes.
            watch.Start();
            List<List<int>> groups =
                FindPrimeGroups(max, spacing, numPerGroup, isPrime);
            watch.Stop();
            iterativeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            numGroupsLabel.Text = groups.Count.ToString();
            Refresh();

            // Use Parallel.For.
            watch.Restart();
            List<List<int>> parallelGroups =
                FindPrimeGroupsInParallel(max, spacing, numPerGroup, isPrime);
            watch.Stop();
            parallelTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
            Console.WriteLine("Parallel found " + parallelGroups.Count + " groups");
            Refresh();

            // Display up to 1,000 the groups.
            foreach (List<int> group in groups.Take(1000))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(group[0]);
                for (int i = 1; i < group.Count; i++)
                    sb.Append(", " + group[i]);
                resultListBox.Items.Add(sb.ToString());
            }

            Cursor = Cursors.Default;
        }

        // Look for groups of primes.
        private List<List<int>> FindPrimeGroups(int max,
            int spacing, int numPerGroup, bool[] isPrime)
        {
            List<List<int>> results = new List<List<int>>();

            // Treat 2 specially.
            List<int> group = GroupAt(2, max, spacing, numPerGroup, isPrime);
            if (group != null) results.Add(group);

            // Check odd primes to see if a group starts there.
            for (int p = 3; p <= max; p += 2)
            {
                group = GroupAt(p, max, spacing, numPerGroup, isPrime);
                if (group != null) results.Add(group);
            }

            // Return the groups we found.
            return results;
        }

        // Parameters used by parallel method CheckForGroupsInParallel.
        private const int NumValuesPerBatch = 10000;
        private object ParallelMaxLockObject = new object();
        private List<List<int>> ParallelGroups = null;
        private int ParallelMax = -1;
        private int ParallelSpacing = -1;
        private int ParallelNumPerGroup = -1;
        private bool[] ParallelIsPrime = null;
        
        // Find groups of primes in parallel.
        private List<List<int>> FindPrimeGroupsInParallel(int max,
            int spacing, int numPerGroup, bool[] isPrime)
        {
            // Initialize the parallel parameters.
            ParallelGroups = new List<List<int>>();
            ParallelMax = max;
            ParallelSpacing = spacing;
            ParallelNumPerGroup = numPerGroup;
            ParallelIsPrime = isPrime;
            
            // Treat 2 specially.
            List<int> group = GroupAt(2, max, spacing, numPerGroup, isPrime);
            if (group != null) ParallelGroups.Add(group);

            // Look for other groups in parallel batches.
            Parallel.For(0, max / NumValuesPerBatch, CheckForGroupsInParallel);

            return ParallelGroups;
        }

        // Check values i * ValuesPerCall through (i + 1) * ValuesPerCall.
        private void CheckForGroupsInParallel(int i)
        {
            // Make a list of groups found in this batch.
            List<List<int>> results = new List<List<int>>();

            // Look for prime groups.
            int start = i * NumValuesPerBatch;
            int stop = start + NumValuesPerBatch;
            if (start % 2 == 0) start++;        // Check odd values.
            if (stop == ParallelMax) stop++;    // Include the original max value.
            for (int j = start; j < stop; j += 2)
            {
                List<int> group = GroupAt(j, ParallelMax, ParallelSpacing,
                    ParallelNumPerGroup, ParallelIsPrime);
                if (group != null) results.Add(group);
            }

            // If we found any groups, add them to the global list.
            if (results.Count > 0)
            {
                lock (ParallelMaxLockObject)
                {
                    ParallelGroups.AddRange(results);
                }
            }
        }

        // Determine whether startIndex begins a group.
        // Return the group or null if there is no group here.
        private List<int> GroupAt(int startIndex, int max,
                int spacing, int numPerGroup, bool[] isPrime)
        {
            // See if there is room for a group.
            if (startIndex + (numPerGroup - 1) * spacing > max)
                return null;

            // If there is no group here, return null.
            for (int i = 0; i < numPerGroup; i++)
                if (!isPrime[startIndex + i * spacing])
                    return null;

            // We found a group. Return it.
            List<int> result = new List<int>();
            for (int i = 0; i < numPerGroup; i++)
                result.Add(startIndex + i * spacing);

            return result;
        }

        // Make Euler's sieve.
        private bool[] MakeEulersSieve(int max)
        {
            // Make the array and mark odd numbers greater than 1 as prime.
            bool[] isPrime = new bool[max + 1];
            for (int i = 3; i <= max; i += 2) isPrime[i] = true;

            // Cross out other multiples.
            for (int i = 3; i <= max; i += 2)
            {
                // See if i is prime.
                if (isPrime[i])
                {
                    // Knock out multiples of p.
                    int maxQ = max / i;
                    if (maxQ % 2 == 0) maxQ--;    // Make it odd.
                    for (int q = maxQ; q >= i; q -= 2)
                    {
                        // Only use q if it is prime.
                        if (isPrime[q]) isPrime[i * q] = false;
                    }
                }
            }
            return isPrime;
        }
    }
}
