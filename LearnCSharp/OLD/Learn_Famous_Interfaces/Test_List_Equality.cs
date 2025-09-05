using System;
using System.Collections.Generic;

namespace Learn_Famous_Interfaces
{
    internal class Test_List_Equality
    {
        // a List<> NEM hív bele a typusos Equals() -ba
        internal static void Run()
        {
            Ember_IEquatable ember1 = new Ember_IEquatable { Age = 10, Name = "Pisti" };
            Ember_IEquatable ember2 = new Ember_IEquatable { Age = 11, Name = "Pisti" };
            Ember_IEquatable ember3 = new Ember_IEquatable { Age = 12, Name = "Pisti" };

            // a list-nél nem hív bele a GetHashCode() -ba csak az Equals-ba

            List<Ember_IEquatable> list = new List<Ember_IEquatable> { ember1, ember1, ember2 };

            Console.WriteLine(list.IndexOf(ember3));
            Console.WriteLine(list.Contains(ember1));
            Console.WriteLine(list.Contains(ember2));  // ha lehet az IEquatable interace által megadott -be hív bele, ha az nincs akkor az object override-jába hív
            Console.WriteLine(list.Contains(ember3));

            list.Remove(ember2);

            Console.ReadKey();
        }
    }
}