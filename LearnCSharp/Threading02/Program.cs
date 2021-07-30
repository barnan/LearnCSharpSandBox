using System;

namespace Threading02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Threads01.Execute();

            System.Console.WriteLine("------------------------------------------");

            Tasks01.Execute();

            System.Console.WriteLine("------------------------------------------");

            QUserWorkItem.Execute();

            System.Console.WriteLine("------------------------------------------");

            //AsyncDelegate.Execute();        // AsyncDelegate nem támogatott .not core alatt

            Console.ReadKey();
        }
    }
}