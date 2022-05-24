using System;

namespace Learn_Famous_Interfaces
{
    internal class Ember_IComparable : IComparable
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}