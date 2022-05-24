using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Array;

namespace Learn_ArraySpeed
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //BitconverterTest.Test();

           //Array_CreateSpeedTest.Test();

            //Array_SetSpeedTest.Test();

            //Array_ReverseSpeedTest.Test();

            Array_SizeTest.Test();

            int k = 10;

            k *= 3 / 2;

            Console.WriteLine(k);

            Console.ReadKey();
        }
    }


    internal static class WedgeImage
    {

        internal static Array GenerateImageType(Type type, int width, int height, double minValue, double maxValue)
        {
            Array data = (byte[])Array.CreateInstance(type, width * height);

            double columnIncrement = (maxValue - minValue) / (width - 1);
            double rowIncrement = (maxValue - minValue) / (height - 1);

            for (int j = 0; j < height; j++)
            {
                double number;
                for (int i = 0; i < j; i++)
                {
                    number = Math.Min(i * columnIncrement, maxValue);       // Math.Min -> to avoid the higher number than the maxValue, otherwise Convert.ChangeType might throw exception
                    data.SetValue(Convert.ChangeType(number, type), j * width + i);
                }

                number = Math.Min(j * rowIncrement, maxValue);
                for (int i = j; i < width; i++)
                {
                    data.SetValue(Convert.ChangeType(number, type), j * width + i);
                }
            }
            return data;
        }


        internal static T[] GenerateImage<T>(int width, int height, double minValue, double maxValue)
        {
            T[] data = new T[width * height];

            double columnIncrement = (maxValue - minValue) / (width - 1);
            double rowIncrement = (maxValue - minValue) / (height - 1);

            for (int j = 0; j < height; j++)
            {
                double number;
                for (int i = 0; i < j; i++)
                {
                    number = Math.Min(i * columnIncrement, maxValue);       // Math.Min -> to avoid the higher number than the maxValue, otherwise Convert.ChangeType might throw exception
                    data[j * width + i] = (T)Convert.ChangeType(number, typeof(T));
                }

                number = Math.Min(j * rowIncrement, maxValue);
                for (int i = j; i < width; i++)
                {
                    data[j * width + i] = (T)Convert.ChangeType(number, typeof(T));
                }
            }
            return data;
        }
    }

}
