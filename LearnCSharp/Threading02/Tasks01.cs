using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading02
{
    internal class Tasks01                      // task api is a threadpoolt használja
    {
        public static void Execute()
        {
            Task<int> intTask = Task.Factory.StartNew<int>(Go3);
            Task.Factory.StartNew(() => Go1());
            Task.Factory.StartNew(Go2);

            Console.WriteLine(intTask.Result);      // csak akkor jut ki a taskból az exception, ha a resultot lekérjük
        }

        private static void Go1()
        {
            Thread.Sleep(1000);

            Console.WriteLine($"hello from {nameof(Go1)} {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");
            throw new Exception($"{nameof(Go1)} exception");
        }

        private static void Go2()
        {
            Console.WriteLine($"hello from {nameof(Go2)} {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");
            throw new Exception($"{nameof(Go2)} exception");
        }

        private static int Go3()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"{nameof(Go3)} végzett");
            //throw new Exception($"{nameof(Go3)} exception");            // csak akkor jut ki a taskból az exception, ha a resultot lekérjük belőle
            return 400;
        }
    }
}