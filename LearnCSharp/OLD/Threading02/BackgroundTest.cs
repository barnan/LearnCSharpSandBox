using System;
using System.Threading;

namespace Threading02
{
    internal class BackgroundTest
    {
        internal static void Execute(string[] args)
        {
                Thread worker = new Thread(() => Console.ReadLine());
                if (args.Length > 0) worker.IsBackground = true;
                worker.Start();
        }
    }
}
