using System;
using System.ComponentModel;

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

    public class Class1
    {
        private static void Main(string[] args)
        {
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
}