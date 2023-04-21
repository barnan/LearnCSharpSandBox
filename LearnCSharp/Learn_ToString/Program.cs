using System;
using System.Globalization;

namespace Learn_ToString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToStringTest_00();
            ToStringTest_01();
            ToStringTest_02();

            int.Parse("2");

            Console.ReadKey();
        }

        private static void ToStringTest_00()
        {
            double d = 200.123456;
            int i = 400;

            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0:#.#####}", d));
            Console.WriteLine(d.ToString("###.###"));
            Console.WriteLine(d.ToString("#####.############"));
            Console.WriteLine(d.ToString("0.000000000000"));

            Console.WriteLine(i.ToString("D"));
            Console.WriteLine(i.ToString("0.0000"));


            // string equality:
            ProcessFlow p1 = new ProcessFlow { Name = "AxisProcess1" };
            ProcessFlow p2 = new ProcessFlow { Name = "AxisProcess1" };
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Name == p2.Name);


            ProcessFlow2 pf1 = new ProcessFlow2 { Name = "AxisProcess2" };
            ProcessFlow2 pf2 = new ProcessFlow2 { Name = "AxisProcess2" };
            Console.WriteLine(pf1 == pf2);
            Console.WriteLine(p1.Name == p2.Name);




            try
            {
                int k = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe) { }
            catch (Exception e) { }
            //catch (ArgumentException ae) { }

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