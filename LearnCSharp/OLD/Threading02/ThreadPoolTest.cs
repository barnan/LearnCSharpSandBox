using System;
using System.Threading;

namespace Threading02
{
    internal class ThreadPoolTest
    {
        internal static void Execute()
        {
            ThreadPool.QueueUserWorkItem(DoSomething1);
            ThreadPool.QueueUserWorkItem(DoSomething2, "State");        // a state -ben az obj paramétert lehet neki átadni

            Thread.Sleep(200);

            Console.ReadKey();
        }

        internal static void DoSomething1(object obj)
        {
            Console.WriteLine($"Entering into DoSomething1() -> {obj}");

            //throw new Exception("Proba");               // kezeletelen exception -nel leáll az alkalmazás
        }

        internal static void DoSomething2(object obj)
        {
            Console.WriteLine($"Entering into DoSomething2() -> {obj}");

        }

    }
}
