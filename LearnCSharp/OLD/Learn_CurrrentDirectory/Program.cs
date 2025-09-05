using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CurrrentDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"AppDomain.CurrentDomain.BaseDirectory: {AppDomain.CurrentDomain.BaseDirectory}");

            Console.WriteLine($"Assembly.GetExecutingAssembly().Location: {Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}");

            Console.WriteLine($"Directory.GetCurrentDirectory(): {Directory.GetCurrentDirectory()}");

            Console.ReadKey();

        }
    }
}
