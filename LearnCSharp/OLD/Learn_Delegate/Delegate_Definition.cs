using System.Reflection;

namespace Learn_Delegate
{
    public static class Delegate_Definition
    {
        internal delegate int DoSomething(int x, int y);
        internal delegate void DoSomethingEvent(int x, int y);
        internal delegate int DoSomethingNOParamater();
        internal delegate T TSomething<T>(T x, T y);

        internal static event DoSomething MyEvent;

        internal static int Add(int x, int y)
        {
            return x + y;
        }

        internal static int Add2(int x, int y)
        {
            return (x + y) * 2;
        }

        internal static int Multiply(int x, int y)
        {
            return x * y;
        }

        internal static void Execute()
        {
            DoSomething something = new DoSomething(Add);

            MethodInfo mi = typeof(Delegate_Definition).GetMethod("Add2", BindingFlags.Static | BindingFlags.NonPublic);
            DoSomething something2 = (DoSomething)Delegate.CreateDelegate(typeof(DoSomething), mi);     // közvetlenül nem lehet példányosítni a delegate-et
            DoSomething something3 = new DoSomething(Multiply);

            DoSomething delegateChain = (DoSomething)Delegate.Combine(something, something2, something3);   // delegate lánc létrehozása (exception esetén megszakad a hívás. És így lefuttatva csak az utolsó eredményét kapjuk vissza)

            DoSomething ds = something;
            ds += something2;               // így is létre lehet hozni delegate láncot

            Console.WriteLine(ds.GetHashCode());

            ds += something3;

            Console.WriteLine(ds.GetHashCode());        // immutable -> egy másik objektumot kapunk vissza az "összeadás" után

            DoSomething ds2 = delegate (int a, int b)       // anonim metódus deiniálása
            {
                return 2 * a + b * b;
            };

            DoSomething ds3 = delegate (int _, int __)      // anonim metódus definiálása, maikor nem vesszük figyelembe a paramétert
            {
                return 1000000;
            };

            DoSomething ds4 = delegate
            {
                return 20;
            };

            TSomething<double> ds5 = delegate (double egyik, double masik)
            {
                return (int)(egyik + masik);
            };

            Console.WriteLine("something1: {0}", something(10, 20));
            Console.WriteLine("delegate chain: {0}", delegateChain(10, 20));        // csak az utolsó eredményét kapjuk vissza
            Console.WriteLine("delegate chain ds: {0}", ds(10, 20));

            Console.WriteLine("getinvocationlist -> {0}", ((DoSomething)delegateChain.GetInvocationList()[1]).Method.Invoke(null, new object[] { 40, 50 }));

            Console.WriteLine("anonim method ds2 -> {0}", ds2(100, 400));
            Console.WriteLine("anonim method ds3 -> {0}", ds3(100, 400));
            Console.WriteLine("anonim method ds4 -> {0}", ds4(100, 400));
            Console.WriteLine("anonim method ds5 -> {0}", ds5(10.3, 40.8));

        }

    }
}