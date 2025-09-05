using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Learn_Enum
{
    public enum SampleShapes
    {
        [Description("valami")]
        Circular,

        Rectangular,
        Linear,
        Spherical,
        SampleHolder,

        Circular_Half_Upper,
        Circular_Quarter_UpperLeft,
        Circular_Quarter_UpperRight,
    }

    public enum SubstrateSize
    {
        Unknown = -1,
        Wafer450 = 8,
        Wafer300 = 1,
        Wafer200 = 2,
        Wafer150 = 3,
        Wafer156 = 7,
        Wafer125 = 4,
        Wafer100 = 5,
        Wafer75 = 6,
        Wafer50 = 9,
        Custom = 10,
        None = 0
    }

    public enum TestEnum
    {
        [Description("Value 1")]
        Val1,
        [Description("Value 2")]
        Val2,
        [Description("Value 3")]
        Val3
    }

    public class Class1
    {
        private static void Main(string[] args)
        {
            var ertekek = new EnumValueRange<SubstrateSize>();

            byte[] bytes = BitConverter.GetBytes((uint)350);


            TestEnum val = TestEnum.Val1;

            Console.WriteLine(val.GetEnumDescription());

            TestEnum zuruck1 = (TestEnum)EnumExtension.GetEnumValueFromDescription(typeof(TestEnum), "Value 3");
            TestEnum zuruck2 = (TestEnum)EnumExtension.GetEnumValueFromText(typeof(TestEnum), "Val2");

            SubstrateSize substrateSize = SubstrateSize.Wafer300;
            string substrateText = substrateSize.ToString("G");
            string waferText = "Wafer";
            SampleShapes sampleShape;

            if (substrateSize <= 0)
            {
                throw new ArgumentException("Nem jó input érték");
            }

            if (substrateSize == SubstrateSize.Custom)
            {
                sampleShape = SampleShapes.Circular;
            }

            string szamertek = substrateText.ToUpperInvariant().Split(new string[] { waferText.ToUpperInvariant() }, StringSplitOptions.RemoveEmptyEntries)[0];





            Console.ReadKey();
        }
    }


    public class EnumValueRange<T> 
        where T : IComparable, IFormattable, IConvertible
    {
        private T[] _values;

        public double[] Values { get; set; }
        public Dictionary<double, string> EnumNames { get; } = new Dictionary<double, string>();

        /// <summary>
        /// Values represented as <see cref="double"/>. Note that the given values are to be interpreted based on <see cref="ValueRange.RangeType"/>.
        /// </summary>
        public T[] GetValues()
        {
            return _values;
        }

        public EnumValueRange()
        {
            _values = (T[])Enum.GetValues(typeof(T));
            Values = Array.ConvertAll<T, double>(_values, delegate(T input)
            {
                return (double)Convert.ChangeType(input, TypeCode.Double);
            } );

            foreach (T value in _values)
            {
                EnumNames.Add((double)Convert.ChangeType(value, TypeCode.Double), (string)Convert.ChangeType(value, TypeCode.String));
            }

            //_values.ForEach(_values, p => EnumNames.Add((double)Convert.ChangeType(p, TypeCode.Double), (string)Convert.ChangeType(p, TypeCode.String)));
            ;
        }
    }

}