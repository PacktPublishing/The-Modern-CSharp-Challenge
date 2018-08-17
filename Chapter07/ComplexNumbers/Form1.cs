using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Perform some test operations.
        private void Form1_Load(object sender, EventArgs e)
        {
            ComplexNumber a = new ComplexNumber(3);
            ComplexNumber b = new ComplexNumber(3, 0);
            ComplexNumber c = new ComplexNumber(3, 4);
            ComplexNumber d = new ComplexNumber(5, 7);
            ComplexNumber f = 13;
            double g = (double)f;
            ComplexNumber h = new ComplexNumber(7, 5);
            ComplexNumber i = new ComplexNumber(1, 1);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ComplexNumber.Zero: {ComplexNumber.Zero}");
            sb.AppendLine($"ComplexNumber.One: {ComplexNumber.One}");
            sb.AppendLine($"ComplexNumber.I: {ComplexNumber.I}");
            sb.AppendLine($"a: {a}");
            sb.AppendLine($"b: {b}");
            sb.AppendLine($"c: {c}");
            sb.AppendLine($"d: {d}");
            sb.AppendLine($"f: {f}");
            sb.AppendLine($"g: {g}");
            sb.AppendLine($"a == b: {a == b}");
            sb.AppendLine($"a == c: {a == c}");
            sb.AppendLine($"-d: {-d}");
            sb.AppendLine($"c + d: {c + d}");
            sb.AppendLine($"c * d: {c * d}");
            sb.AppendLine($"c - d: {c - d}");
            sb.AppendLine($"c / d: {c / d}");
            sb.AppendLine($"d * (c / d): {d * (c / d)}");
            sb.AppendLine($"c == (d * (c / d)): {c == (d * (c / d))}");
            sb.AppendLine($"c * 3: {c * 3}");
            sb.AppendLine($"3 * c: {3 * c}");
            sb.AppendLine($"c + 3: {c + 3}");
            sb.AppendLine($"3 + c: {3 + c}");
            sb.AppendLine($"c - 3: {c - 3}");
            sb.AppendLine($"3 - c: {3 - c}");
            sb.AppendLine($"c / 3: {c / 3}");
            sb.AppendLine($"3 / c: {3 / c}");
            sb.AppendLine($"3 * (c / 3): {3 * (c / 3)}");
            sb.AppendLine($"c * (3 / c): {c * (3 / c)}");
            string s = "3 + 5i";
            sb.AppendLine($"ComplexNumber.Parse(\"{s}\"): {ComplexNumber.Parse(s)}");
            s = "8i";
            sb.AppendLine($"ComplexNumber.Parse(\"{s}\"): {ComplexNumber.Parse(s)}");
            s = "13";
            sb.AppendLine($"ComplexNumber.Parse(\"{s}\"): {ComplexNumber.Parse(s)}");
            sb.AppendLine($"({d}).GetHashCode()): { d.GetHashCode()}");
            sb.AppendLine($"({h}).GetHashCode()): { h.GetHashCode()}");
            sb.AppendLine($"({i}).Magnitude: { i.Magnitude}");
            sb.AppendLine($"({i}).Angle * 180 / Pi: { i.Angle * 180 / Math.PI}");

            resultsTextBox.Text = sb.ToString();
            resultsTextBox.Select(0, 0);
        }
    }
}
