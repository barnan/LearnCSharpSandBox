using System;

namespace Learn_Array
{
    class Array_SizeTest
    {
        internal static void Test()
        {
            int width = 100;
            int height = 100;

            byte[] array01 = new byte[height * width];

            Console.WriteLine("byte array.length: {0}", array01.Length);                    
            Console.WriteLine("byte array.getlength: {0}", array01.GetLength(0));
            Console.WriteLine("byte Buffer.ByteLength: {0}", Buffer.ByteLength(array01));

            ushort[] array02 = new ushort[height * width];

            Console.WriteLine("ushort array.length: {0}", array02.Length);                          // ez az elemek számát adja meg
            Console.WriteLine("ushort array.getlength: {0}", array02.GetLength(0));                 // ez az elemek számát adja meg
            Console.WriteLine("ushort Buffer.ByteLength: {0}", Buffer.ByteLength(array02));         // ez a bájt méretet adja meg


        }
    }
}
