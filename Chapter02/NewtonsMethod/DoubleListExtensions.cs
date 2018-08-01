using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsMethod
{
    public static class DoubleListExtensions
    {
        public static bool Contains(this List<double> values,
            double target, double maxDiff)
        {
            foreach (double value in values)
                if (Math.Abs(value - target) <= maxDiff)
                    return true;
            return false;
        }
    }
}