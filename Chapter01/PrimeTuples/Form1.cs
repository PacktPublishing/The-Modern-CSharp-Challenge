using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeTuples
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
            numGroupsLabel.Text = "";
            Refresh();

            int max = int.Parse(maxTextBox.Text);
            int spacing = int.Parse(spacingTextBox.Text);
            int number = int.Parse(numberTextBox.Text);

            // Make a sieve.
            bool[] isPrime = MakeEulersSieve(max);

            // Look for groups of primes.
            List<List<int>> groups =
                FindPrimeGroups(max, spacing, number, isPrime);

            // Display the groups.
            foreach (List<int> group in groups)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(group[0]);
                for (int i = 1; i < group.Count; i++)
                    sb.Append(", " + group[i]);
                resultListBox.Items.Add(sb.ToString());
            }
            numGroupsLabel.Text = resultListBox.Items.Count.ToString();
        }

        // Look for groups of primes.
        private List<List<int>> FindPrimeGroups(int max,
            int spacing, int number, bool[] isPrime)
        {
            List<List<int>> results = new List<List<int>>();

            // Treat 2 specially.
            List<int> group = GroupAt(2, max, spacing, number, isPrime);
            if (group != null) results.Add(group);

            // Check odd primes to see if a group starts there.
            for (int p = 3; p <= max; p += 2)
            {
                group = GroupAt(p, max, spacing, number, isPrime);
                if (group != null) results.Add(group);
            }

            // Return the groups we found.
            return results;
        }

        // Determine whether the indicated number begins a group.
        // Return the group or null if there is no group here.
        private List<int> GroupAt(int startIndex, int max,
            int spacing, int number, bool[] isPrime)
        {
            // See if there is room for a group.
            if (startIndex + (number - 1) * spacing > max)
                return null;

            // If there is no group here, return null.
            for (int i = 0; i < number; i++)
                if (!isPrime[startIndex + i * spacing])
                    return null;

            // We found a group. Return it.
            List<int> result = new List<int>();
            for (int i = 0; i < number; i++)
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
