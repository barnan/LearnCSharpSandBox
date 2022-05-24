using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learn_CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource ts = new CancellationTokenSource();
            CancellationToken token = ts.Token;



            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    
                    token.ThrowIfCancellationRequested();
                    //if (token.IsCancellationRequested)
                    //{
                    //    break;
                    //}
                }
            }, 
                token);

            Thread.Sleep(1000);

            ts.Cancel();

            Thread.Sleep(2000);

            //if (t1.Status != TaskStatus.Canceled)
            //{
                t1.Wait();
            //}

            Console.WriteLine("Valami");
            Console.ReadKey();
        }
    }
}
