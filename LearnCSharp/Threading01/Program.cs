using System;
using Threading01;

namespace Threading02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Threads02.Execute();

            DelegateTest.Execute();

            AsyncDelegate.Execute();

            Console.ReadKey();
        }
    }
}