using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Class_2
{
    internal class BaseClass
    {
        int _field1;
        static int _field2;

        internal static void DoSomething1()
        {
            Console.WriteLine("Base DoSomething 1 ");
        }

        internal virtual void DoSomething2()
        {
            Console.WriteLine("Base DoSomething 2 ");
        }

        internal virtual void DoSomething3()
        {
            Console.WriteLine("Base DoSomething 3 ");
        }

    }
}
