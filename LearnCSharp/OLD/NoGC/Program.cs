using System;
using System.Runtime;

namespace NoGC
{
    public class Resource
    {
        private byte[] bytes = new byte[1000000];

        ~Resource()
        {
            Console.WriteLine("Finalize called");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //GCSettings.LatencyMode = GCLatencyMode.LowLatency;

            try
            {
                GC.TryStartNoGCRegion(15 * 1024 * 10124, disallowFullBlockingGC: true);        // GC.Collect-et is tartalmaz
                for (int i = 0; i < 15; i++)
                {
                    new Resource();
                }

                System.Console.WriteLine("Objects created");
            }
            finally
            {
                Console.WriteLine("No GC region end");
                if (GCSettings.LatencyMode == GCLatencyMode.NoGCRegion)
                {
                    GC.EndNoGCRegion();
                }
            }

            Console.ReadKey();
        }
    }
}