using System;
using System.Threading;

namespace Learn_Famous_Interfaces
{
    internal class Object_Equality
    {
        internal static void Run()
        {
            CancellationTokenSource hello1 = new CancellationTokenSource();
            CancellationTokenSource hello2 = new CancellationTokenSource();
            //CancellationTokenSource hello2 = hello1;

            Console.WriteLine(Equals(hello1, hello2));                       // 1, alapból a object.Equals(obj1, obj2) is referencia ellenőrzést csinál
            Console.WriteLine(ReferenceEquals(hello1, hello2));              // 2, Referencia összehasonlítás, mint a neve is mutatja
            Console.WriteLine(hello1.Equals(hello2));                        // 3, az 1-es bal oldali objektumának equals(obj) metódusát hívja
            Console.WriteLine(hello1 == hello2);

            Console.WriteLine(Equals(hello1, hello1));                       // 1, alapból a object.Equals(obj1, obj2) is referencia ellenőrzést csinál
            Console.WriteLine(ReferenceEquals(hello1, hello1));              // 2, Referencia összehasonlítás, mint a neve is mutatja
            Console.WriteLine(hello1.Equals(hello1));                        // 3, az 1-es bal oldali objektumának equals(obj) metódusát hívja
            Console.WriteLine(hello1 == hello1);

            //double d1 = 10;
            //double d2 = 10;

            //Console.WriteLine(Object.Equals(d1, d2));                           // ez overrideolja a ValueType, reflection-t használ, célszerű overrideolni
            //Console.WriteLine(Object.ReferenceEquals(d1, d2));                  // ez értéktípusra mindig false
            //Console.WriteLine(d1.Equals(d2));                                   // ez override-olható a típusban
            //Console.WriteLine(d1 == d2);                                        // ez is override-olható a típusban

            Console.ReadKey();
        }
    }
}