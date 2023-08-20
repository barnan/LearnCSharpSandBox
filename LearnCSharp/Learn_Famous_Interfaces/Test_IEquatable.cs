using System;

namespace Learn_Famous_Interfaces
{
    internal class Test_IEquatable
    {
        internal static void Run()
        {
            Ember_IEquatable ember1 = new Ember_IEquatable { Age = 10, Name = "Józsi" };
            Ember_IEquatable ember2 = new Ember_IEquatable { Age = 10, Name = "Pisti" };

            Console.WriteLine(Equals(ember1, ember2));
            Console.WriteLine(ember1.Equals(ember2));       // ha az IEquatable definiálva van benne vagy csak szerepel benne a típusos metódus, akkor arrra hív, egyébként pedig a sima bool Equals(obj) override-jára
            Console.WriteLine(ReferenceEquals(ember1, ember2));
            Console.WriteLine(ember1 == ember2);                        // ezt is külön override-olni kell, nem elég az Equals()-t override-olni

            // ha nincs a classban definiálva a IEquatable, akkor az összes false, ellenkező esetben oda hív be
        }
    }
}