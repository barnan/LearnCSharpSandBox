using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GC_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Timer timer = new Timer(TimerTick, null, 0, 1000);      // eager root collection -> a fordító figyeli, hogy mi a lokális változónak az utolsó előfordulási sora
                                                                    // debug módban máshogy működik ez az optimalizáció -> az utolsó sorra írja be ezt az előfordulást
            Console.ReadLine();
            //timer.Dispose();

            // timer = null;            // nem működik, fordító kiszűri
            // timer.ToString();        // működik, de egy felesleges hívás
            // Timer t2 = timer;        // új változó, nem
            // M(timer);                 // inlineolja ezt a rövid metódust

            GC.KeepAlive(timer);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]          // ezzel beállítjuk, hogy ne inline-olja be
        private static void M(Timer timer)
        {
        }

        private static void TimerTick(object state)
        {
            Console.WriteLine("Tick");
            GC.Collect();                   // release módban nem fut le csak egyszer
        }
    }
}