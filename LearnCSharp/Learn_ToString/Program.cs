using System;

namespace Learn_ToString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToStringTest_01();
            ToStringTest_02();

            Console.ReadKey();
        }

        private static void ToStringTest_01()
        {
            double k = 8.3990999999999989;

            Console.WriteLine($"wo rounding: {k.ToString("R")}");
            Console.WriteLine($"wi rounding: {k.ToString()}");
        }

        private static void ToStringTest_02()
        {
            object variable01 = null;

            Console.WriteLine(Convert.ToString(variable01));
            //Console.WriteLine(variable01.ToString());             // a sima ToString() nem tud null-t kezelni
        }
    }
}