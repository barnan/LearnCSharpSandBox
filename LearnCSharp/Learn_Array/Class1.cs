using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Learn_Array;

namespace Learn_ArraySpeed
{
    public class Class1
    {

        private static byte[] STOP_MESSAGE = new byte[] { 0x55, 0xAA, 0x03, 0x00, 0x03 };

        private static byte[] ARBITRARY_MESSAGE = new byte[] { 0x52, 0x32, 0x52, 0x20, 0x31, 0x31, 0x38, 0x5F, 0x31, 0x31, 0x30, 0x0D };
        private static byte[] ARBITRARY_MESSAGE_2 = new byte[] { 0x4C, 0x4F, 0x4E, 0x0D };
        
        
        private static byte[] ARBITRARY_MESSAGE_3 = new byte[] { 0x32, 0x30, 0x32, 0x32, 0x31, 0x30, 0x31, 0x37, 0x31, 0x34, 0x33, 0x34, 0x34, 0x30, 0x38, 0x35, 0x30, 0x3B };
        private static byte[] ARBITRARY_MESSAGE_4 = new byte[] { 0x2D, 0x32, 0x32, 0x32, 0x32, 0x31, 0x2E, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x35, 0x33, 0x3B };
        private static byte[] ARBITRARY_MESSAGE_5 = new byte[] { 0x32, 0x30, 0x32, 0x32, 0x31, 0x30, 0x31, 0x37, 0x31, 0x34, 0x33, 0x37, 0x32, 0x31, 0x39, 0x39, 0x31, 0x3B, 0x2D, 0x32, 0x32, 0x32, 0x32, 0x31, 0x2E, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x35, 0x33, 0x3B, 0x0D };

           
            
        static void Main(string[] args)
        {
            //string stopMessage = BitConverter.ToString(STOP_MESSAGE);
            //string arbitraryMessage = Encoding.ASCII.GetString(ARBITRARY_MESSAGE_2);
            //string arbitraryMessage_3 = Encoding.ASCII.GetString(ARBITRARY_MESSAGE_3);
            //string arbitraryMessage_4 = Encoding.ASCII.GetString(ARBITRARY_MESSAGE_4);
            //string arbitraryMessage_5 = Encoding.ASCII.GetString(ARBITRARY_MESSAGE_5);

            //Console.WriteLine(arbitraryMessage);
            //Console.WriteLine(arbitraryMessage_3);
            //Console.WriteLine(arbitraryMessage_4);
            //Console.WriteLine(arbitraryMessage_5);
            //Console.WriteLine(ResponseContainsError(arbitraryMessage));
            //Console.WriteLine(stopMessage);

            // ***************************************************************************************--

            var array = System.Array.CreateInstance(typeof(int), new[] { 5 }, new int[] { 2 });     // így lehet tömböt nem 0 kezdőindexszel létrehozni)

            BitconverterTest.Test();

            Array_CreateSpeedTest.Test();       // körülbelül egyforma a kettős sebessége (A GC szerintem ezt nagyon befolyásolja)

            Array_SetSpeedTest.Test();          // az indexer sokkal gyorsabb (kb egy nagyságrend)

            Array_ReverseSpeedTest.Test();      // az array metódusa gyorsabb

            Array_SizeTest.Test();

            Array_Test.Test();

            Array_Conversion.Test();


            Console.ReadKey();
        }

        internal static bool ResponseContainsError(string response)
        {

            string regexPattern = "ER,[\\w]+,[\\d]{2}";
            string errorString = "ER";
            Regex reg = new Regex(regexPattern);

            if (!response.Contains(errorString) && !reg.Match(response).Success)
            {
                return false;
            }

            //_commonParameters.Logger.Error($"ERROR message received: {response}");

            string[] parts = response.Split(new char[] { ',', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 2 && ErrorDictionary.ContainsKey(parts[2]))
            {
                //_commonParameters.Logger.Error($"Meaning of the error response: {ErrorDictionary[parts[2]]}");
            }

            return true;
        }

        internal static Dictionary<string, string> ErrorDictionary { get; } = new Dictionary<string, string>()
                                                                                  {
                                                                                      { "00", "Undefined command received" },
                                                                                      { "01", "Mismatched command format (Invalid number of parameters)" },
                                                                                      { "02", "The parameter 1 value exceeds the set value" },
                                                                                      { "03", "The parameter 2 value exceeds the set value" },
                                                                                      { "04", "Parameter 2 is not set in HEX (hexadecimal) code" },
                                                                                      { "05", "Parameter 2 set in HEX (hexadecimal) code but exceeds the set value" },
                                                                                      { "10", "There are 2 or more ! marks in the preset data Preset data is incorrect" },
                                                                                      { "11", "Area specification data is incorrect" },
                                                                                      { "12", "Specified file does not exist" },
                                                                                      { "13", "\"mm\" for the %Tmm-LON,bb command exceeds the setting range" },
                                                                                      { "14", "Communication cannot be checked with the %Tmm-KEYENCE command" },
                                                                                      { "20", "This command is not executable in the current status (execution error" },
                                                                                      { "21", "The buffer has overflowed, so commands cannot be executed" },
                                                                                      { "22", "An error occurred while loading or saving parameters, so commands cannot be executed" },
                                                                                      { "23", "Commands sent from RS-232C cannot be received because AutoID Network Navigator is being connected" },
                                                                                      { "99", "SR-1000 Series may be faulty. Please contact your nearest KEYENCE sales office" }
                                                                                  };
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

        internal static void GenerateImage_2<T>()
        {
            T[] data = new T[0];

        }



        

    }

}
