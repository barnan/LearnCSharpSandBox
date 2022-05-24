using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    class Array_SizeTest
    {
        internal static void Test()
        {
            int width = 100;
            int height = 100;

            byte[] array01 = new byte[height * width];

            Console.WriteLine(array01.Length);
            Console.WriteLine(array01.GetLength(0));
            Console.WriteLine(Buffer.ByteLength(array01));

            ushort[] array02 = new ushort[height * width];

            Console.WriteLine(array02.Length);
            Console.WriteLine(array02.GetLength(0));
            Console.WriteLine(Buffer.ByteLength(array02));


        }
    }
}
