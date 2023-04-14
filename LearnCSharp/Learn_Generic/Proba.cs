using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Generic
{
    internal static class Proba
    {


        public static TNew ConvertValue<TOld, TNew>(TOld value)
        {
            object result = null;
            TNew newType = default(TNew);

            //Bool & byte
            if (newType is bool)
            {
                result = Convert.ToBoolean(value, CultureInfo.InvariantCulture);
            }
            else if (newType is byte)
            {
                result = Convert.ToByte(value, CultureInfo.InvariantCulture);
            }
            //16 bit integer
            else if (newType is short)
            {
                result = Convert.ToInt16(value, CultureInfo.InvariantCulture);
            }
            else if (newType is ushort)
            {
                result = Convert.ToUInt16(value, CultureInfo.InvariantCulture);
            }
            //32 bit integer
            else if (newType is int)
            {
                result = Convert.ToInt32(value, CultureInfo.InvariantCulture);
            }
            else if (newType is uint)
            {
                result = Convert.ToUInt32(value, CultureInfo.InvariantCulture);
            }
            //64 bit integer
            else if (newType is long)
            {
                result = Convert.ToInt64(value, CultureInfo.InvariantCulture);
            }
            else if (newType is ulong)
            {
                result = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
            }
            //Floating points
            else if (newType is float)
            {
                result = Convert.ToSingle(value, CultureInfo.InvariantCulture);
            }
            else if (newType is double)
            {
                result = Convert.ToDouble(value, CultureInfo.InvariantCulture);
            }
            else if (newType is decimal)
            {
                result = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
            }

            if (result == null && typeof(TNew).Equals(typeof(string)))
            {
                if (typeof(TOld).IsEnum)
                {
                    result = Enum.GetName(typeof(TOld), value);
                }
                else
                {
                    result = value.ToString();
                }
            }

            /* case: Write enum to enum typed register */
            if (result == null && typeof(TOld) == typeof(TNew))
            {
                result = value;
                return (TNew)result;
            }

            if (result != null)
            {
                return (TNew)result;
            }
            throw new ArgumentException($"Cannot convert from type \"{typeof(TOld).Name}\" to \"{typeof(TNew).Name}\"!");
        }



    }
}
