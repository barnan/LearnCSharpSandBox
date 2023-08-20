using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    internal class Array_SetSpeedTest
    {
        internal static void Test()
        {
            int cycleNumber = 1000;
            int arraySize = 100000;

            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            byte[] data2 = new byte[arraySize];


            for (int m = 0; m < cycleNumber; m++)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    data2[i] = 100;
                }
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int m = 0; m < cycleNumber; m++)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    data2.SetValue((byte)200, i);
                }
            }

            watch1.Stop();

            Console.WriteLine($"array.setvalue: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int m = 0; m < cycleNumber; m++)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    data2[i] = 100;
                }
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int m = 0; m < cycleNumber; m++)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    data2.SetValue((byte)200, i);
                }
            }

            watch1.Stop();

            Console.WriteLine($"array.setvalue: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int m = 0; m < cycleNumber; m++)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    data2[i] = 100;
                }
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");
        }

    }
}
