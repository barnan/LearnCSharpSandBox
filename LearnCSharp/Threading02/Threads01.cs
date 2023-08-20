using System;
using System.Threading;

namespace Threading02
{
    internal class Threads01
    {
        public static void Execute()
        {
            try
            {
                Thread.CurrentThread.Name = "fő szál";

                Thread t = new Thread(new ThreadStart(WaitTest_Go));         // threadStart egy delegate (paraméter és visszatérési érték nélküli)
                t.Name = "egyes szál";
                t.Name = "1. szál";
                t.IsBackground = false;

                Thread t2 = new Thread(new ParameterizedThreadStart(GoWithParameter));         // parameterizedthreadstart egy delegate (PARAMÉTERES és visszatérési érték nélküli)
                t2.Name = "kettes szál";                                                          // név csak egyszer adható neki
                t2.IsBackground = false;                                                        // az alapértelmezett az előtérszáll. background szál esetén a finaly sem fut le, egyszerűen elhal az alkalmazás

                t.Start();

                Thread.Sleep(100);
                Console.WriteLine($"t state: {t.ThreadState}");

                t.Join();
                t2.Start("hihi");

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception happened");                                        // kezeletlen kivétel esetén leáll az app!!    -> explicit módon kell kezelni a futtatott metódusban!!!!
            }
        }

        private static void Go()
        {
            Console.WriteLine($"hello from {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");

            // throw new Exception($"{nameof(Go)} exception");
        }

        private static void GoWithParameter(object parameter)
        {
            Console.WriteLine($"{parameter} hello from {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");

            // throw new Exception($"{nameof(GoWithParameter)} exception");   -> explicit módon kell kezelni
        }

        private static void WaitTest_Go()
        {
            Thread.CurrentThread.Name = "szál";
            Console.WriteLine($"{nameof(WaitTest_Go)} hello from {Thread.CurrentThread.Name}, {Thread.CurrentThread.IsAlive} {Thread.CurrentThread.ThreadState} {Thread.CurrentThread.Priority} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.GetApartmentState()}");
            Thread.Sleep(5000);
        }
    }
}