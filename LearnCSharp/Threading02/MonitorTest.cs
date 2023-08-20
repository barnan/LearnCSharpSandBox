using System;
using System.Threading;

namespace Threading02
{
    internal class MonitorTest
    {
        static int _counter = 0;
        static object _lockObj = new object();


        internal static void Execute()
        {
            Thread thread1 = new Thread(ThreadFunction1);
            Thread thread2 = new Thread(ThreadFunction2);

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        internal static void ThreadFunction1()
        {
            lock (_lockObj)
            {
                for (int i = 0; i < 50; i++)
                {
                    Monitor.Wait(_lockObj, Timeout.Infinite);   // wait-nél lemond a zárról (a _lockObj -ról), átadjjja a vazérlést másnak
                    
                    Console.WriteLine("{0} from thread {1}", ++_counter, Thread.CurrentThread.ManagedThreadId);

                    Monitor.Pulse(_lockObj);                // készenléti sorba helyezzük át a sorban következő szálat, aki a enne ka szállnak a
                                                            // Wait-be lépésekor ténylegesen meg is kapja a vezérlést
                }
            }
        }

        internal static void ThreadFunction2()
        {
            lock(_lockObj)
            {
                for (int i = 0; i < 50; i++)
                {
                    Monitor.Pulse(_lockObj);
                    
                    Monitor.Wait(_lockObj, Timeout.Infinite);

                    Console.WriteLine("{0} from thread {1}", ++_counter, Thread.CurrentThread.ManagedThreadId);
                }
            }
        }
    }
}
