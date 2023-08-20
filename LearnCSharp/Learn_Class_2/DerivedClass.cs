using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Class_2
{
    internal class DerivedClass : BaseClass
    {
        internal sealed override void DoSomething2()
        {
            Console.WriteLine("Derived DoSomething 2");
        }

        internal new void DoSomething3()
        {
            Console.WriteLine("Derived DoSomething 3");
        }

    }
}
