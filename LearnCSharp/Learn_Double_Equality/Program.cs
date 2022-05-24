using System;
using System.Collections.Generic;

namespace Learn_Double_Equality
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double k = 8.3990999999999989;

            Dictionary<double, int> dict = new Dictionary<double, int>(new DoubleEqualityComparer())
            {
                { 0, 0 },
                { 0.0263, 1 },
                { 0.4115, 1 },
                { 0.9778, 1 },
                { 1.643, 1 },
                { 2.2755, 1 },
                { 2.941, 1 },
                { 3.6635, 1 },
                { 4.285, 1 },
                { 5.0627, 1 },
                { 6.0168, 1 },
                { 6.5197, 1 },
                { 7.372, 1 },
                { 8.3991, 117 },
                { 9.2791, 1 },
                { 10.2096, 1 },
                { 10.6635, 1 },
                { 11.6689, 1 },
                { 12.7917, 1 },
                { 13.5014, 1 },
                //{ 8.39912, 1 }
            };

            Console.WriteLine(dict.ContainsKey(k));

            int item_value;
            dict.TryGetValue(k, out item_value);

            Console.ReadKey();
        }
    }
}