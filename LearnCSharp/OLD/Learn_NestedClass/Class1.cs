using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_NestedClass
{
    public class Class1
    {

        static void Main(string[] args)
        {

            Outer outer = new Outer();

            Outer.Internal intern = new Outer.Internal();
           
            Console.ReadKey();
        }
    }

    public class Outer
    {

        public Outer()
        {

        }


        public class Internal
        {
            public static bool Prop01 { get; set; }

            public static void DoSomething()
            {
                Console.WriteLine("Do Something!!");
            }
        }
    }


}
