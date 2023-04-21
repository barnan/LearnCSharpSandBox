using System;

namespace Learn_Interface
{
    public interface IInterface01
    {
        static IInterface01()                   // static constructor
        {
            staticField = 20;
        }

        public const int constField = 10;       // konstans field
        public static int staticField = 30;     // static field

        static int StaticProperty               // static property
        {
            get;
            set;
        }

        internal static void StaticMethod()      // static method
        {
            staticField = 30;
        }

        int InstanceProperty { get; }           // instance property

        // ha interface-ben adunk meg default paramétert akkor az csak interface-en keresztül hívva fog működni
        void InstanceMethod(int k = 300);       // instance method

        internal int this[int i]                // instance indexer access modifierrel (csak explicit implementációban definiálható a classban)
        {
            get => staticField;
            set => staticField++;
            //get; set;
        }



        event EventHandler InstanceEvent;
    }
}

// Interface tartalmazhat:
// - instance property
// - instance event
// - instance indexer
// - instance method

// C# 8.0 óta tartalmazhat még:
// - static fieldet
// - konstanst (egyben static is)
// - static metódust
// - static konstruktort

// Nem tartalmazhat:
// - instance konstruktort
// - instance fieldet
// - instance finalizert

// lehet benne access modifiereket definiálni
// private esetén kell a default implementáció
// ha egy osztály származik belőle, akkor minden memberét definiálnia kell az interface-nek kivéve, amihez van default implementáció
// az default implemetentációval rendelkező memberek implicit virtual-ok és felüldefiniálhatóak, kivéve, ha sealed vagy private-nak vannak megadva