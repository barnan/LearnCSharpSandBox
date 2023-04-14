using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Generic
{
    class Klass
    {
        private byte[] content;

        public Klass(byte[] input, bool allocate)
        {
            content = input;
        }


        public Klass(ushort[] input)
        {
            //content = input;
        }



        public Klass(double[] input)
        {
            //content = input;
        }

        

    }
}
