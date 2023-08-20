using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Generic
{
    internal class Valami
    {
    }


    internal class Valami<T> : Valami
    {
        private T ize = default(T);


        public Valami(T input)
        {
            ize = input;


        }

        public void Ir(T input)
        {
            ize = input;
        }

        public void Ir<G>(G input)
        {
            // ize = input;       // tipuskonverzio szukseges
        }
    }
}
