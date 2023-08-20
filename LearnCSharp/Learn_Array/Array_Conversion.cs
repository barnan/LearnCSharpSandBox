using System;
using System.Linq;

namespace Learn_Array
{
    internal class Array_Conversion
    {
        internal static void Test()
        {

            ////// EZT HIÁBA ÍRJA A KÖNYV, NEM MŰKÖDIK!!!!!!!!!!   csak object  -tel
            //BaseClass[] baseArray = new BaseClass[] { new BaseClass(), new BaseClass(), new BaseClass() };
            //DerivedClass[] derivedArray = baseArray;

            string[] stringArray = new string[] { "1", "2", "3", "4" };
            object[] objectArray = stringArray;

            int[] intArray = new int[] { 1, 2, 3, 4 };
            long[] longArray = Array.ConvertAll(intArray, Convert.ToInt64);
            //long[] longArray2 = intArray.Cast<long>();        // ???

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

            foreach (var item in longArray)
            {
                Console.WriteLine(item);
            }

        }
    }


    internal class BaseClass
    {
        int egyik;
    }

    internal class DerivedClass : BaseClass
    {
        int masik;
    }

}
