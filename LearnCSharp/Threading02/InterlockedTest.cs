using System;
using System.Threading;

namespace Threading02
{
    internal class InterlockedTest
    {
        static int _numberOfThreads;
        static private Random _rnd = new Random();

        internal static void Execute()
        {
            Thread readerThread = new Thread(ReadThreadNumber);
            readerThread.Start();
            readerThread.IsBackground = true;

            Thread[] threads = new Thread[50];
            for (int i = 0; i < 50; i++)
            {
                threads[i] = new Thread(RandomThreadFunction);
                threads[i].Start();
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }


        internal static void RandomThreadFunction()
        {
            Interlocked.Increment(ref _numberOfThreads);
            try
            {
                int time = _rnd.Next(1000, 12000);
                Thread.Sleep(time);
            }
            finally
            {
                Interlocked.Decrement(ref _numberOfThreads);
            }
        }


        internal static void ReadThreadNumber()
        { 
            while (true)
            {
                int threadCount;
                threadCount = Interlocked.Exchange(ref _numberOfThreads, _numberOfThreads);
                Console.WriteLine(threadCount);
                Thread.Sleep(1000);
            }
        }


        
    }
}
