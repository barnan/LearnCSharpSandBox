using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Threading01
{
    internal class Threads02
    {
        static ManualResetEvent _mre = new ManualResetEvent(false);

        public static void Execute()
        {
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            Thread th1 = new Thread(Go);
            th1.Name = "Thread1";
            //th1.Name = "Thread1";           // .net framework alatt csak egyszer lehet állítani!!!  Egyszer, de akár elidítás után is!!  .Net core alatt többször is!!
            th1.Start();

            Thread.Sleep(1000);
            
            //th1.Interrupt();            // ez csak WaitSleepJoin state-ből szedi ki!!!

            th1.Suspend();              // ezt is csak a .net framework támogatja, a .net core már nem

            Thread.Sleep(2000);

            th1.Resume();

            Thread.Sleep(200);

            _mre.Reset();

            Thread.Sleep(200);

            th1.Abort("csakazértis Thread.Abort() !!!");            // ez csak .net framework alatt működik!!

            th1.Join();

            Console.WriteLine(watch1.ElapsedMilliseconds);

            Console.ReadKey();
        }

        private static void Go(object obj)
        {
            int count = 0;
            try
            {
                //Thread.Sleep(Timeout.Infinite);         // ez végtelenségig várakozik
                //Thread.Sleep(0);                          // csak az éppen aktuális ütemező ciklusból ugrik ki, a következőben újra fut

                while (true)                          // ha ez fut, akkor a Thread.Interrupt nem állítja meg, 
                {
                    Console.WriteLine(count++);

                    // WaitHandle.WaitAny(new WaitHandle[] { _mre });       Könyv szerint ez blokkolna a Thread.Abort-ot, de nekem nem
                    
                }

                //Thread.Sleep(8000);

                Console.WriteLine("While was ended");
            }
            catch (Exception ex)                            // a thread.abort exception a catch után újra dobódik!!
            {                                               // a thread.iterrupt nem dobodik ujra a catch után
                Console.WriteLine(ex);
                Thread.ResetAbort();                        // ez megállítja a ThreadAbortException újradobását!
            }
            Console.WriteLine("Go was ended");
        }
    }
}
