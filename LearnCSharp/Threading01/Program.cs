using System;

namespace Threading02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AsyncDelegate.Execute();

            Console.ReadKey();
        }
    }
}