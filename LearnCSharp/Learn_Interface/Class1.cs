using System;

internal class global               // nem célszerű, globális névtér szennyezés!!!!
{
}

namespace Learn_Interface
{
    internal partial class Class1 : IInterface01
    {
        private int k = 20;
        private Class2 class2 = new Class2();

        internal int this[int i]                  // ha van az interface-ben access modifier-e akkor itt explicitként kell definiálni. Ha van implementációja az interface-ben akkor nem követli meg hogy itt implementálva legyen egyébként IGEN!!
        {
            get => k;
            set => k = 10;
        }

        //int IInterface01.InstanceProperty
        //{
        //    get;
        //}

        public int InstanceProperty
        {
            get;
            set;
        }

        public event EventHandler InstanceEvent;

        public void InstanceMethod(int k = 500)
        {
            Console.WriteLine(k);
        }
    }

    internal partial class Class1          // abstract is static is lehet a partial class, de akkor is static lesz az összes többi részlet is
    { }
}