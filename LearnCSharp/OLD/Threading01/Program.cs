using System;

namespace Threading01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AsyncDelegateTest.Execute();

            Threads02.Execute();

            DelegateTest.Execute();

            Console.ReadKey();
        }
    }
}