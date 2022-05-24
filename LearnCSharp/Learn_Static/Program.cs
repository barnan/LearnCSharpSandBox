using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Static
{
    class Program
    {
        static void Main(string[] args)
        {
          


            Klass1 klass1 = new Klass1();
            klass1.Beallit();

            Console.ReadKey();
        }
    }


    


    public class Klass1
    {
        internal static Klass2 beallito = new Klass2();

        public Klass1()
        {
            ;
        }

        public void Beallit()
        {
            Klass3 klass3 = beallito.klass3;
        }
    }

    public class Klass2
    {
        internal Klass3 klass3 => new Klass3();

        static Klass2()
        {
            ;
        }

        public Klass2()
        {
            ;
        }


    }

    public class Klass3
    {

        public Klass3()
        {
            ;
        }
    }
}
