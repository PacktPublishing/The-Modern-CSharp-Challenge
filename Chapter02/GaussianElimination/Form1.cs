using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussianElimination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Solve the system of equations.
        private void solveButton_Click(object sender, EventArgs e)
        {
            // Build the augmented matrix.
            // The values numRows and numCols are the number of rows
            // and columns in the matrix, not the augmented matrix.
            int numRows, numCols;
            double[,] arr = LoadArray(out numRows, out numCols);
            double[,] origArr = LoadArray(out numRows, out numCols);

            // Display the initial arrays.
            PrintArray(arr);
            PrintArray(origArr);

            // Perform Gaussian elimination.
            try
            {
                GaussianEliminate(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Display the modified array in the Console window.
            PrintArray(arr);

            // Display the results on the form.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    Values");
            for (int r = 0; r < numRows; r++)
            {
                sb.AppendLine("x" + r.ToString() + " = " +
                    arr[r, numCols + 1].ToString());
            }

            // Verify.
            sb.AppendLine();
            sb.AppendLine("    Check:");
            for (int r = 0; r < numRows; r++)
            {
                double tmp = 0;
                for (int c = 0; c < numCols; c++)
                    tmp += origArr[r, c] * arr[c, numCols + 1];
                sb.AppendLine(tmp.ToString());
            }
            resultsTextBox.Text = sb.ToString();
        }

        // Perform Gaussian elimination.
        // Note that arr should be the augmented array.
        // Initially the second-to-last column should hold the result values.
        // In the end, the final column will hold the variables' final values after backsolving.
        private void GaussianEliminate(double[,] arr)
        {
            const double tiny = 0.00001;

            // Get the number of rows and columns.
            int numRows = arr.GetUpperBound(0) + 1;
            int numCols = arr.GetUpperBound(1) - 1;

            // Start solving.
            for (int r = 0; r < numRows - 1; r++)
            {
                // Zero out all entries in column r after this row.
                // See if this row has a non-zero entry in column r.
                if (Math.Abs(arr[r, r]) < tiny)
                {
                    // Too close to zero. Try to swap with a later row.
                    for (int r2 = r + 1; r2 < numRows; r2++)
                    {
                        if (Math.Abs(arr[r2, r]) > tiny)
                        {
                            // This row will work. Swap them.
                            for (int c = 0; c <= numCols; c++)
                            {
                                double tmp = arr[r, c];
                                arr[r, c] = arr[r2, c];
                                arr[r2, c] = tmp;
                            }
                            break;
                        }
                    }
                }

                // If this row has a non-zero entry in column r, use it.
                if (Math.Abs(arr[r, r]) > tiny)
                {
                    // Zero out this column in later rows.
                    for (int r2 = r + 1; r2 < numRows; r2++)
                    {
                        double factor = -arr[r2, r] / arr[r, r];
                        for (int c = r; c <= numCols; c++)
                        {
                            arr[r2, c] = arr[r2, c] + factor * arr[r, c];
                        }
                    }
                }
            }

            // Display the upper-triangular array. (For debugging.)
            PrintArray(arr);

            // See if we have a solution.
            if (arr[numRows - 1, numCols - 1] == 0)
            {
                // We have no solution.
                // If all entries in this row are 0, then there is no solution.
                // Otherwise the solution is not unique.
                for (int c = 0; c <= numCols + 1; c++)
                    if (arr[numRows - 1, c] != 0)
                        throw new Exception("There is no solution");
                throw new Exception("The solution is not unique");
            }

            // We have a solution. Backsolve.
            for (int r = numRows - 1; r >= 0; r--)
            {
                double tmp = arr[r, numCols];
                for (int r2 = r + 1; r2 < numRows; r2++)
                {
                    tmp -= arr[r, r2] * arr[r2, numCols + 1];
                }
                arr[r, numCols + 1] = tmp / arr[r, r];
            }
        }

        // Load the augmented array.
        // Column numCols holds the result values.
        // Column numCols + 1 will hold the variables' final values after backsolving.
        private double[,] LoadArray(out int numRows, out int numCols)
        {
            // Build the augmented matrix.
            string[] valueRows = valuesTextBox.Text.Split(
                new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] coefRows = coefficientsTextBox.Text.Split(
                new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] oneRow = coefRows[0].Split(
                new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            numRows = coefRows.GetUpperBound(0) + 1;
            numCols = oneRow.GetUpperBound(0) + 1;
            double[,] arr = new double[numRows, numCols + 2];
            for (int r = 0; r < numRows; r++)
            {
                oneRow = coefRows[r].Split(
                    new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < numCols; c++)
                {
                    arr[r, c] = double.Parse(oneRow[c]);
                }
                arr[r, numCols] = double.Parse(valueRows[r]);
            }

            return arr;
        }

        // Display the array's values in the Console window.
        private void PrintArray(double[,] arr)
        {
            for (int r = arr.GetLowerBound(0); r <= arr.GetUpperBound(0); r++)
            {
                for (int c = arr.GetLowerBound(1); c <= arr.GetUpperBound(1); c++)
                {
                    Console.Write(arr[r, c] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
