
using System.Diagnostics.CodeAnalysis;

namespace Classes_Structs
{
    internal class PrimaryConstr(double valtozo1)
    {
        double _valtozo1 = valtozo1;

        // primary kontrsuktornál nem lehet egyébb műveletet belevenni a ctr-be, csak beállítást:
        //Console.WriteLine(_valtozo1);


        // egy random metódusban is felhasználható, NEM definiál hozzájuk field-et, olyan mintha egy alkapott változó lenne -> heap-en van már ez a változó????
        internal void Method01()
        {
            var valami = (double)valtozo1;
        }


        public PrimaryConstr() : this(10)       // több konstruktor így definiálható, csak this -szel!!!
        {
        }

    }


    internal class NormalConstr
    {
        public NormalConstr(double valtozo1)
        {
            double _valtozo1 = valtozo1;
            Console.WriteLine(_valtozo1);
        }

        public NormalConstr()
        {
            double _valtozo1 = 10;
            Console.WriteLine(_valtozo1);
        }

        public NormalConstr(bool valami) : this(10)
        {
        }

    }
    

    internal class InitValtozo
    {
        private double myVar1;
        public double MyVar1
        {
            get { return myVar1; }
            set { myVar1 = value; }
        }

        private double myVar2;
        public double MyVar2
        {
            get { return myVar2; }
            init { myVar2 = value; }
        }

        private double myVar3;
        public required double MyVar3
        {
            get { return myVar3; }
            init { myVar3 = value; }
        }

        // REQUIRED:
        // object initializer-ként KELL megadni, NEM ELÉG a ctor-ban megadni!!
        // LEHET a required-et null-ra inicializálni
        // required-nek kell accessor (init vagy set)
        // required lehet field vagy property
        // lehet osztályban, structban, recordban, record structban
        // required-nek legalább olyan láthatóság kell, mint a tartalmazó osztálynak
        // NEM LEHET new-val felüldefiniálni a gyerek osztályban
        // Ovorride esetén is kell a required szó a gyerek osztályba
        // explicit interface implmementáció NEM LEHET required
        private double myVar4;
        public required double MyVar4
        {
            get { return myVar4; }
            init { myVar4 = value; }
        }

        public InitValtozo(double valtozo1, double valtozo2, double valtozo3)
        {
            MyVar1 = valtozo1;
            MyVar3 = valtozo3;
        }

        [SetsRequiredMembers]
        public InitValtozo()
        {
        }

    }
}
