using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public struct ComplexNumber : IEquatable<ComplexNumber>
    {
        // Auto-implemented properties.
        private double Re { get; }
        private double Im { get; }

        // Constructors.
        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public ComplexNumber(double re)
        {
            Re = re;
            Im = 0;
        }

        // Polar factory method.
        public static ComplexNumber FromPolar(double magnitude, double angle)
        {
            return new ComplexNumber(
                magnitude * Math.Cos(angle),
                magnitude * Math.Sin(angle));
        }

        // Return 0, 1, or i.
        private static ComplexNumber ComplexZero = new ComplexNumber();
        private static ComplexNumber ComplexOne = new ComplexNumber(1);
        private static ComplexNumber ComplexI = new ComplexNumber(0, 1);
        public static ComplexNumber Zero
        {
            get { return ComplexZero; }
        }
        public static ComplexNumber One
        {
            get { return ComplexOne; }
        }
        public static ComplexNumber I
        {
            get { return ComplexI; }
        }

        // Display as in x + yi.
        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }

        // Parse from a string.
        public static ComplexNumber Parse(string s)
        {
            double re = 0, im = 0;
            if (s.Contains("+"))
            {
                // Real and imaginary parts.
                int pos = s.IndexOf("+");
                string rePart = s.Substring(0, pos - 1);
                re = double.Parse(rePart);

                string imPart = s.Substring(pos + 1).ToLower().Replace("i", "");
                im = double.Parse(imPart);
            }
            else if (s.ToLower().Contains("i"))
            {
                // Imaginary part only.
                string imPart = s.ToLower().Replace("i", "");
                im = double.Parse(imPart);
            }
            else
            {
                // Real part only.
                re = double.Parse(s);
            }

            return new ComplexNumber(re, im);
        }

        // Equality and IEquatable<ComplexNumber>.
        public bool Equals(ComplexNumber other)
        {
            double dRe = Re - other.Re;
            double dIm = Im - other.Im;
            return (dRe * dRe + dIm * dIm == 0);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is ComplexNumber)) return false;
            ComplexNumber other = (ComplexNumber)obj;
            return (Re == other.Re) && (Im == other.Im);
        }
        public bool Equals(ComplexNumber other, double precision)
        {
            double dRe = Re - other.Re;
            double dIm = Im - other.Im;
            return (dRe * dRe + dIm * dIm <= precision * precision);
        }

        // Comparison operators.
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        // GetHashCode.
        public override int GetHashCode()
        {
            return Re.GetHashCode() ^ (Re + Im).GetHashCode();
        }

        // Return the number's magnitude. (Also called its modulus or norm.)
        public double Magnitude
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }

        // Return the number's angle. (Also called its argument or phase.)
        public double Angle
        {
            get { return Math.Atan2(Im, Re); }
        }

        // Type conversion operators.
        // Convert the double value re into the ComplexNumber re + 0i.
        public static implicit operator ComplexNumber(double re)
        {
            return new ComplexNumber(re);
        }

        // Convert the ComplexNumber into a double by dropping the complex part.
        public static explicit operator double(ComplexNumber c)
        {
            return c.Re;
        }

        // Arithmetic operators.
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re + c2.Re, c1.Im + c2.Im);
        }
        public static ComplexNumber operator -(ComplexNumber c1)
        {
            return new ComplexNumber(-c1.Re, -c1.Im);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Re * c2.Re - c1.Im * c2.Im,
                c1.Re * c2.Im + c1.Im * c2.Re);
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            double denominator = c2.Re * c2.Re + c2.Im * c2.Im;
            return new ComplexNumber(
                (c1.Re * c2.Re + c1.Im * c2.Im) / denominator,
                (c1.Im * c2.Re - c1.Re * c2.Im) / denominator);
        }
    }
}
