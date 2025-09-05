using System;
using System.Runtime.InteropServices;

namespace HandleCollectorDemo
{
    internal class Program
    {
        // akkor lehet hasznos, ha vmi drága erőforrás kiment a scope-ból és azonnal fel akarjuk takaríttatni
        // de vigyázni kell, mert nemcsak ezek az objektumok takarítódnak ki, hanem az egész GC lefut, minden objektumot kitakarít, és mindenki objektumait öregíti

        public class Resource
        {
            private static readonly HandleCollector hc = new HandleCollector("Resource", 3);            // ha 3-at elérte ebből a példányok száma, akkor meghívódik a GC, de csak akkor szabadít fel, ha unrooted

            public Resource()
            {
                hc.Add();
                Console.WriteLine($"Resource created: {hc.Count}");
            }

            ~Resource()
            {
                hc.Remove();
                Console.WriteLine($"Resource finalized: {hc.Count}");
            }
        }

        private static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                new Resource();             // unrooted-ként vannak definiálva
            }

            Console.WriteLine("Objects created");
            Console.ReadLine();
        }
    }
}