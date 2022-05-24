using System;
using System.Threading;

namespace Threading02
{
    internal class QUserWorkItem                // threadpoolt használja
    {
        public static void Execute()
        {
            ThreadPool.QueueUserWorkItem(Go1, 10);                          // nem ad módot arra, hogy resultot kapjunk vissza belőle
            ThreadPool.QueueUserWorkItem(Go2);
        }

        private static void Go1(object input1)
        {
            Thread.Sleep(1000);

            Console.WriteLine($"hello from {nameof(Go1)} {input1} {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");

            //throw new Exception($"{nameof(Go1)} exception");              // ez nem kezeli az exception-t, kijön belőle -> expicit módon kell kezelni a kivételt benne
        }

        private static void Go2(object input2)
        {
            Console.WriteLine($"hello from {nameof(Go2)} {input2} {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");
        }
    }
}