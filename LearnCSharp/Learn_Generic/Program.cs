using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            Valami<double> v = new Valami<double>(100);

            object obj = (object)v;

            Console.WriteLine(obj.GetType());


            byte bajt = Proba.ConvertValue<int, byte>(300);


            Console.ReadKey();

        }






    }
}
