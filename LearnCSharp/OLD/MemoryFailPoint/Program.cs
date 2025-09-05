using System;
using System.Runtime;

namespace MemoryFail
{
    // "fail fast" megközelítés -> ha vmi rossz, akkor minnél hamarabb szálljon el

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var mf = new MemoryFailPoint(2000))          // insufficient memory exception -> jelez, ha nincs elég memória, pl. egy algoritmus indulásakor
            {
                System.Console.WriteLine("Algorithm running");
            }

            Console.ReadLine();
        }
    }
}