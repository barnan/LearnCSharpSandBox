using System;

namespace Learn_Double_Equality
{
    internal static class Equality
    {
        public const double MIN_NORMAL_DOUBLE = (1L << 52) * double.Epsilon;

        public static bool NearlyEquals(this double x, double y, double epsilon)
        {
            return NearlyEqual(x, y, epsilon);
        }

        private static bool NearlyEqual(double x, double y, double epsilon)
        {
            // shortcut, handles infinities
            if (x == y)
            {
                return true;
            }

            // x or y is zero or both are extremely close to it
            // relative error is less meaningful here
            double diff = Math.Abs(x - y);
            if (x == 0 || y == 0 || diff < MIN_NORMAL_DOUBLE)
            {
                return diff < epsilon;
            }

            // use relative error
            return diff / (Math.Abs(x) + Math.Abs(y)) < epsilon;
        }
    }
}