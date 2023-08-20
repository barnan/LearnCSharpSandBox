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
            DateTime dateValue = new DateTime(2009, 6, 1, 16, 37, 0);
            CultureInfo[] cultures = {  new CultureInfo("en-US"),
                                        new CultureInfo("fr-FR"),
                                        new CultureInfo("hu-HU"),
                                        new CultureInfo("de-DE") };
            Console.WriteLine($"{dateValue.ToString("G", cultures[0])} getformat -> {0}", cultures[0].GetFormat(typeof(NumberFormatInfo)));
            Console.WriteLine($"{dateValue.ToString("G", cultures[1])} getformat -> {0}", cultures[1].GetFormat(typeof(NumberFormatInfo)));
            Console.WriteLine($"{dateValue.ToString("G", cultures[2])} getformat -> {0}", cultures[2].GetFormat(typeof(NumberFormatInfo)));
            Console.WriteLine($"{dateValue.ToString("G", cultures[3])} getformat -> {0}", cultures[3].GetFormat(typeof(NumberFormatInfo)));

            Console.WriteLine(string.IsInterned("valami ") != null);
            string.Intern($"valami {0}");
            Console.WriteLine(string.IsInterned($"valami {0}") != null);
            Console.WriteLine(string.IsInterned($"valami {1}") != null);

            //Console.WriteLine(string.IsInterned($"valami " + "1") != null);


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
            ProcessFlow p3 = new ProcessFlow { Name = $"AxisProcess{1}" };
            ProcessFlow p4 = new ProcessFlow { Name = string.Format("AxisProcess{0}", 1) };
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Name == p2.Name);
            Console.WriteLine(p1.Name == p3.Name);
            Console.WriteLine(p1.Name == p4.Name);


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