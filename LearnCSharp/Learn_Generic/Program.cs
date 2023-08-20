using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            Valami<double> v = new Valami<double>(100);
            object obj = (object)v;
            Console.WriteLine(obj.GetType());

            // ***********************************************************************

            
            int[] intList = new int[] { 1, 2, 3 };
            //long[] longList = intList;        // ezt nem engedi a fordíto
            object[] objList = intList.Cast<object>().ToArray();
            Array array = intList;


            Console.WriteLine(objList.GetType());
            Console.WriteLine(array.GetType());

            // ***********************************************************************

            Strukt<double> strukt = new Strukt<double>(30.3);

            // ***********************************************************************

            byte bajt1 = Proba.ConvertValue<int, byte>(200);
            // byte bajt2 = Proba.ConvertValue<int, byte>(300);         // exception-t fog dobni


            Console.ReadKey();

        }






    }
}
