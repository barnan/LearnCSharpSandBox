using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;

namespace LearnEmgu
{
    static class AllocationTest
    {
        public static void Test()
        {
            Console.WriteLine(GC.GetTotalMemory(true));

            int width = 10000;
            int height = 10000;
            byte[] myByteArray = new byte[width * height];
            myByteArray[10] = 40;

            Console.Write("1 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            Image<Gray, byte> testImage1 = new Image<Gray, byte>(width, height);
            Image<Gray, byte> testImage2 = new Image<Gray, byte>(width, height);

            Console.Write("2 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            byte[] fromEmgu1 = testImage1.Bytes;

            Console.Write("3 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            testImage2.Bytes = myByteArray;

            Console.Write("4 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            testImage2.SetValue(30);

            Console.Write("5 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            byte[] fromEmgu2 = testImage2.Bytes;

            Console.Write("6 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            byte[] data = new byte[width * height / 4];

            Console.Write("7 ******");
            Console.WriteLine(GC.GetTotalMemory(true));

            var gcHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr ptr = gcHandle.AddrOfPinnedObject();
            using (Image<Gray, byte> tempImage = new Image<Gray, byte>(width / 2, height / 2, width / 2, ptr))
            {
                //CvInvoke.cvCopy(testImage2.Ptr, tempImage.Ptr, IntPtr.Zero);
                CvInvoke.Resize(testImage2, tempImage, new Size(width / 2, height / 2));
                data[5] = 100;

                byte[] data2 = tempImage.Bytes;

                Console.Write("8 ******");
                Console.WriteLine(GC.GetTotalMemory(true));
            }

            gcHandle.Free();
        }
    }
}
