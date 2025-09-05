using System;

namespace Learn_Interface.Interface_Selection
{
    internal class InterfaceSelectionTester
    {
        internal static void Test()
        {
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class2.DoSomething02();
            //class2.DoSomething02_2();

            class3.DoSomething02();
            //class3.DoSomething02_2();
            class3.DoSomething03();

            IInterface02 iclass3 = class3 as IInterface02;
            iclass3.DoSomething02();
            iclass3.DoSomething02_2();

            Console.ReadKey();
        }
    }
}