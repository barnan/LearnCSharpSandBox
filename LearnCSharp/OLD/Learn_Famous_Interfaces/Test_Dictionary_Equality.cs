using System;
using System.Collections.Generic;

namespace Learn_Famous_Interfaces
{
    internal class Test_Dictionary_Equality
    {
        internal static void Run()
        {
            Ember_IEquatable ember1 = new Ember_IEquatable { Age = 10, Name = "Pisti" };
            Ember_IEquatable ember2 = new Ember_IEquatable { Age = 11, Name = "Pisti" };

            // a dictionary-ben a különböző egyenlőség vizsgálatoknál elősször hív GetHashCode()-ot aztán Equals() -t (ha a hashcode alapján egyenlőséget talál)

            Dictionary<Ember_IEquatable, int> dict = new Dictionary<Ember_IEquatable, int>
            {
                { ember1, 1 },
                { ember2, 3 }
            };

            Console.WriteLine(dict.ContainsKey(ember1));

            dict.Remove(ember2);
        }
    }
}