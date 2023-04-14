using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    class BitconverterTest
    {
        internal static void Test()
        {
            float valami = 1000;
            byte[] bvalami = BitConverter.GetBytes(valami);

            byte[] data = new byte[4];

            int number = (int)valami;
            data[0] = Convert.ToByte(number & 0xFF);
            data[1] = Convert.ToByte((number & 0xFF00) >> 8);
            data[2] = Convert.ToByte((number & 0xFF0000) >> 16);
            data[3] = Convert.ToByte((number & 0xFF000000) >> 24);

            double tesztVariable01 = Double.NaN;

            string tesztVariable02 = "NaN";//tesztVariable01.ToString();

            double tesztVariable03 = 1234.1234;

            //byte nTesztVariable = Convert.ToByte(tesztVariable03);

            bool bTtesztVariable01 = Convert.ToBoolean(tesztVariable01);
            //bool bTtesztVariable02 = Convert.ToBoolean(tesztVariable02);
            bool bTtesztVariable03 = Convert.ToBoolean(tesztVariable03);

        }
    }
}
