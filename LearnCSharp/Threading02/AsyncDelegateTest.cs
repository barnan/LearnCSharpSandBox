using System;
using System.Threading;

namespace Threading02
{
    internal class AsyncDelegateTest
    {
        delegate int MyDelegate(int x, int y);

        internal static void Execute()
        {
            MyDelegate del1 = delegate (int x, int y)
            {
                Console.WriteLine($"del1 in {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
                return x + y;
            };

            MyDelegate del2 = new MyDelegate(delegate (int x, int y)                // így is lehet definiálni
            {
                Console.WriteLine($"del2 in {Thread.CurrentThread.ManagedThreadId}");
                return x * y;
            });

            Console.WriteLine(del1(10, 30));
            Console.WriteLine(del2(10, 30));

            del1.BeginInvoke(40, 50, CallBackMethod, "ezt a szoveget küldöm");

            Console.ReadKey();
        }

        private static void CallBackMethod(IAsyncResult ar)
        {
            MyDelegate work = (MyDelegate)ar.AsyncState;
            Console.WriteLine($"state -> {work}");

            int result = work.EndInvoke(ar);        // blokkoló hívás, megvárja az eredményt
            Console.WriteLine($"result -> {result}");
        }
    }
}
