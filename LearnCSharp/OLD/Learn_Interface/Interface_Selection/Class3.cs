using System;

namespace Learn_Interface.Interface_Selection
{
    internal class Class3 : Class2, IInterface03
    {
        public void DoSomething03()
        {
            Console.WriteLine("Class3 - DoSomething03");
        }

        void IInterface02.DoSomething02()           // akkor is ezt hívja, ha nincs a fejlécben kiírva az újraimplementálás
        {
            Console.WriteLine("IInterface02.DoSomething02 - explicit implementation in Class3");
        }

        //public override void DoSomething02_2()          // akkor is ezt hívja, ha nincs a fejlécben kiírva az újraimplementálás
        //{
        //    System.Console.WriteLine("Class3 - DoSomething02_2 - override");
        //}
    }
}