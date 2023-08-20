using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Class_2
{
    internal class AnotherDerivedClass : DerivedClass
    {
        internal new void DoSomething2()
        {
            Console.WriteLine("AnotherDerivedClass DoSomething 2");
        }
    }
}
