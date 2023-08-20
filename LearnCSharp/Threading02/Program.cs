using System;

namespace Threading02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BackgroundTest.Execute(new string[] { "heheh" });

            System.Console.WriteLine("------------------------------------------");

            AsyncDelegateTest.Execute();

            System.Console.WriteLine("------------------------------------------");

            ThreadPoolTest.Execute();

            System.Console.WriteLine("------------------------------------------");

            MonitorTest.Execute();

            System.Console.WriteLine("------------------------------------------");

            InterlockedTest.Execute();

            System.Console.WriteLine("------------------------------------------");

            //Threads02.Execute();

            System.Console.WriteLine("------------------------------------------");

            Threads01.Execute();

            System.Console.WriteLine("------------------------------------------");

            Tasks01.Execute();

            System.Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }
}