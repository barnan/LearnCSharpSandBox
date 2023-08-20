using System;
using System.Diagnostics;
using System.Threading;

namespace Threading02
{
    internal class TLSClass
    {
        public TLSClass()
        {
            Console.WriteLine($"{typeof(TLSClass)} is instantiated");           // ez csak egyszer hívódik meg!!
        }
    }

    internal class TSClassContainer
    {
        [ThreadStatic]                                                          // az attributum miatt 
        internal static TLSClass klass = new TLSClass();

        [ThreadStatic]
        internal static int klass2;
        
    }



    internal class TLSClass2
    {
        static TLSClass2()
        {
            slot = Thread.AllocateDataSlot();
        }

        public TLSClass2()
        {
            Console.WriteLine($"Creating {typeof(TLSClass2)}");
        }

        public static TLSClass Slot
        {
            get
            {
                object obj = Thread.GetData(slot);
                if (obj == null)
                {
                    obj = new TLSClass();
                    Thread.SetData(slot, obj);
                }
                return (TLSClass)obj;
            }
        }


        internal static LocalDataStoreSlot slot = null;
    }



    internal class Threads02
    {
        public static void Execute()
        {
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            Thread th1 = new Thread(Go);
            Thread th2 = new Thread(Go);
    
            th1.Start();
            th2.Start();

            Console.ReadKey();
        }

        private static void Go(object obj)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is started");

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} klass: {TSClassContainer.klass}  {TSClassContainer.klass?.GetHashCode()}");

            TSClassContainer.klass2 = Thread.CurrentThread.ManagedThreadId;             // ha nincs ott a threadstatic, akkor a második szál felülírja az első szál által látott értéket is

            Thread.Sleep(100);

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} klass2: {TSClassContainer.klass2}  {TSClassContainer.klass2.GetHashCode()}");

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is ended");
        }
    }
}
