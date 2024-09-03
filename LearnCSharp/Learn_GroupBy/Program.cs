using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn_ToString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numList = new List<int> { 11, 12, 13, 14, 14, 20 };
            List<int> expList = new List<int> { 2, 2, 2, 2, 2, 2 };
            

            var duplicates = numList.Select((t, i) => new { Index = i, Value = t })
                .GroupBy(g => g.Value)
                .Where(g => g.Count() > 1);

            foreach (var duplicate in duplicates)
            {
                var element = duplicate.ToList();
            }


            Console.ReadKey();
        }
    }
}