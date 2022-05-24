﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    internal class Array_ReverseSpeedTest
    {
        internal static void Test()
        {
            // ************************************************************************************

            int cycleNumber = 1000;
            int arraySize = 1000000;

            byte[] data = new byte[arraySize];
            byte[] data2 = new byte[arraySize];

            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            for (int i = 0; i < cycleNumber; i++)
            {
                Array.Reverse(data);
            }

            watch1.Stop();

            Console.WriteLine($"Reverse: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int i = 0; i < cycleNumber; i++)
            {
                for (int j = 0; j < arraySize / 2; j++)
                {
                    byte tempHolder = data[j];
                    data[j] = data[arraySize - j - 1];
                    data[arraySize - j - 1] = tempHolder;
                }
                
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");

            watch1.Restart();

            for (int i = 0; i < cycleNumber; i++)
            {
                Array.Reverse(data);
            }

            watch1.Stop();

            Console.WriteLine($"indexer: {watch1.ElapsedMilliseconds}");

            Console.ReadKey();

        }
    }
}
