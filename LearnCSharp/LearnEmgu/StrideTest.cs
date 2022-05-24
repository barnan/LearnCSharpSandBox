using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace LearnEmgu
{
    static class StrideTest
    {
        public static void Test()
        {
            int w = 13;
            int h = 5;

            Image<Gray, byte> testImage1 = new Image<Gray, byte>(w, h);
            Image<Bgr, byte> testImage11 = new Image<Bgr, byte>(w, h);
            Image<Bgra, byte> testImage12 = new Image<Bgra, byte>(w, h);
            Image<Gray, ushort> testImage2 = new Image<Gray, ushort>(w, h);
            Image<Bgr, ushort> testImage21 = new Image<Bgr, ushort>(w, h);
            Image<Bgra, ushort> testImage22 = new Image<Bgra, ushort>(w, h);
            Image<Gray, float> testImage3 = new Image<Gray, float>(w, h);
            Image<Bgr, float> testImage31 = new Image<Bgr, float>(w, h);
            Image<Bgra, float> testImage32 = new Image<Bgra, float>(w, h);

            var bytes1 = testImage1.Bytes;
            var bytes11 = testImage11.Bytes;
            var bytes12 = testImage12.Bytes;
            var bytes2 = testImage2.Bytes;
            var bytes21 = testImage21.Bytes;
            var bytes22 = testImage22.Bytes;
            var bytes3 = testImage3.Bytes;
            var bytes31 = testImage31.Bytes;
            var bytes32 = testImage32.Bytes;

            Console.WriteLine(bytes1.Length);
            Console.WriteLine(bytes11.Length);
            Console.WriteLine(bytes12.Length);
            Console.WriteLine(bytes2.Length);
            Console.WriteLine(bytes21.Length);
            Console.WriteLine(bytes22.Length);
            Console.WriteLine(bytes3.Length);
            Console.WriteLine(bytes31.Length);
            Console.WriteLine(bytes32.Length);
        }
    }
}
