
using System;

namespace Learn_Class
{
    internal abstract class Class2 : Class1
    {
        public Class2(int in1, int in2, string in3) 
            : base(in1, in2, in3)
        {
        }

        public sealed override void DoSomething()
        {
            
        }

        public abstract override void DoSomething_2();      // a virtuális metódus is tehető újra abstract-tá
    }
}
