using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    internal class Array_CreateSpeedTest
    {
        internal static void Test()
        {
            int cycleNumber = 1000;
            int arraySize = 1000000;

            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            for (int i = 0; i < cycleNumber; i++)
            {
                byte[] data = (byte[])Array.CreateInstance(typeof(byte), arraySize);
            }

            watch1.Stop();

            Console.WriteLine($"array.create: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int i = 0; i < cycleNumber; i++)
            {
                byte[] data = new byte[arraySize];
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int i = 0; i < cycleNumber; i++)
            {
                byte[] data = (byte[])Array.CreateInstance(typeof(byte), arraySize);
            }

            watch1.Stop();

            Console.WriteLine($"array.create: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int i = 0; i < cycleNumber; i++)
            {
                byte[] data = new byte[arraySize];
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");
        }


    }
}
