using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Interface_2
{
    public delegate void ArbitraryEventHandler(object? sender, int valami, string text, MyEventArgs args);
    

    internal interface IInterface_01
    {
        public delegate void ArbitraryEventHandler2(object? sender, int valami, string text, MyEventArgs args);
        

        // without body definition -> ezek a hagyományos interface tagok

        string Prop1 { get; set; }

        int Prop2 { get; set; }

        int this[int index] { get; set; }

        int Method1(int input);

        EventHandler PropEventHandler { get; set; }      // -> ez tul képpen egy delagate típusú változó

        event EventHandler<MyEventArgs> ThresholdReached;        // ez egy event
        


        // default implementation ->

        public void MyMethod(int k)
        {
            Console.WriteLine($"{nameof(MyMethod)} -> {k}");
            ThresholdReached += OnThresholdReached;
        }

        private void OnThresholdReached(object? sender, MyEventArgs e)
        {
        }
        
        // constant -> 
        const int konstans = 10;
        


        // operator overloading -> 

        //static virtual bool operator == (IInterface_01 interface1, IInterface_01 interface2)
        //{
        //    return interface1.Prop1 == interface2.Prop1; 
        //}

        //static virtual bool operator != (IInterface_01 interface1, IInterface_01 interface2)
        //{
        //    return interface1.Prop1 != interface2.Prop1;
        //}
        


        // static constructor -> no access modifier, no parameter

        static IInterface_01()
        {
            konstans2 = 21;
        }



        // nested types -> implicit private, csak a tartalmazó osztályból elérhető

        class NestedClass
        {
            internal int nestedclassfield;
        }


        // static field, methods, properties, indexer, event -> 

        internal static int konstans2 = 11;

        static int Metodus(int k)
        {
            konstans2 = 5 * k;
            return konstans2;
        }



        // metódus láthatósági módosítóval -> implicit virtual (?)  -> hát nem
        // a default implementációval rendelkező metódusokat nem kell implmentálni a class-ban
        internal int Method2(int input)
        {
            return konstans2; 
        }

    }


    public class MyEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

}
