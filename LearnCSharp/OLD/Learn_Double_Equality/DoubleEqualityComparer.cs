using System;
using System.Collections.Generic;

namespace Learn_Double_Equality
{
    internal class DoubleEqualityComparer : IEqualityComparer<double>
    {
        private int DIGITS = 4;
        private double EPSILON = 0.0001;

        public bool Equals(double x, double y)
        {
            return Math.Round(x, DIGITS, MidpointRounding.AwayFromZero) == Math.Round(x, DIGITS, MidpointRounding.AwayFromZero);
        }

        // Egyenletesen fedje le az értékkészletet -> nem teljesül
        // Ne változzon, ha az érték változik -> primitív típusról van szó -> nincs értelme
        //
        public int GetHashCode(double number)
        {
            return (int)Math.Round(Math.Round(number, DIGITS) / EPSILON);
        }

        /// <summary>
        /// Other solution: use the Semilab's double equality comparison:
        /// </summary>
        //
        //private double EPSILON = 0.0001;
        //
        //public bool Equals(double x, double y)
        //{
        //    return x.NearlyEquals(y, EPSILON);
        //}
        //
        ///// <summary>
        ///// this method (GetHashCode) should cover the (double) value-set consistently.
        ///// However in this case it is not completed, but probably numbers around 0 will be given as input in this application.
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <returns></returns>
        //public int GetHashCode(double obj)
        //{
        //    double number = (double)obj;
        //    return (int)(number * EPSILON);
        //}
    }
}