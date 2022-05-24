using System;
using System.Threading;

namespace Threading02
{
    internal class AsyncDelegate
    {
        public static void Execute()
        {
            Func<int, int> exec = new Func<int, int>(Go1_Square);

            exec.BeginInvoke(2000, HandleResult, exec);                         // ugyanazok a paraméterei, mint a hivatkozott metódusnak + 2 (egyik az asynccallback, másik információ a callback-ben hívott metódusnak)
        }

        private static int Go1_Square(int input1)
        {
            Thread.Sleep(input1);
            throw new Exception($"{nameof(Go1_Square)} exception");

            return input1 * input1;
        }

        private static void HandleResult(IAsyncResult aresult)
        {
            Func<int, int> target = (Func<int, int>)aresult.AsyncState;
            int result = target.EndInvoke(aresult);                                 // az exception itt jön ki, vagyis amikor lekérjük a resultot

            Console.WriteLine($"Result {result} received");
        }
    }
}