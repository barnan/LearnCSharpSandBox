using Learn_Interface.Interface_Selection;
using System;
using System.Collections.Generic;

namespace Learn_Interface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            KeyValuePair<DateTime, uint> valami = default(KeyValuePair<DateTime, uint>);
            Console.WriteLine(valami);

            Console.WriteLine("Hello World!");

            // interface kiválasztás
            InterfaceSelectionTester.Test();

            // global:

            global global = new global();

            // Struct

            Struct1 struct1 = new Struct1();

            Struct1 struct2 = new Struct1(struct1);
            Struct1.D = 10;

            struct1.Method02();

            // boxing:

            object obj = struct1;
            struct1.k = 10000000;

            Console.WriteLine($"boxing után: {((Struct1)obj).k}");
            Console.WriteLine(struct1.k);

            // új interface feature-ök

            Class1 class1 = new Class1();
            IInterface01 interface01 = class1 as IInterface01;
            interface01.InstanceMethod();       // itt az interfaceből jön a default param értéke
            class1.InstanceMethod();            // itt a classból jön a default param értéke

            IInterface01.StaticMethod();
            Console.WriteLine(IInterface01.staticField);        // a static constructor + a static method eddigre már felülírta

            class1.InstanceProperty = 30;
            Console.WriteLine(interface01.InstanceProperty);
            Console.WriteLine(class1.InstanceProperty);

            Console.WriteLine(interface01[30]);
            Console.WriteLine(class1[30]);

            // dictionary mérete:
            Dictionary<string, string> probaDict = new Dictionary<string, string>(50);
            probaDict.Add("elso", "elso");

            Console.WriteLine(probaDict.Count);

            Console.WriteLine();
        }
    }
}