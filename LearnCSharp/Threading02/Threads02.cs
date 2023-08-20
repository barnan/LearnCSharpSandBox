using System;
using System.Diagnostics;
using System.Threading;

namespace Threading02
{
    internal class TLSClass
    {
        public TLSClass(string input = "")
        {
            Console.WriteLine($"{typeof(TLSClass)} is instantiated -> {input}");           // ez csak egyszer hívódik meg!! mivel a TSClassContainer static field inicializálója csak egyszer hívódik meg
        }
    }

    internal class TSClassContainer
    {
        [ThreadStatic]                                                          // az attributum miatt 
        internal static TLSClass klass = new TLSClass("fix");

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
                    long id = Thread.CurrentThread.ManagedThreadId;

                    obj = new TLSClass(id.ToString());
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

            th1.Join();
            th2.Join();

            Thread th3 = new Thread(Go2);
            Thread th4 = new Thread(Go2);

            th3.Start();
            th4.Start();

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

        private static void Go2()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is started");

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Slot: {TLSClass2.Slot}  {TLSClass2.Slot?.GetHashCode()}");

            Thread.Sleep(100);

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Slot: {TLSClass2.Slot}  {TLSClass2.Slot.GetHashCode()}");

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is ended");
        }
    }
}
