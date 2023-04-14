using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Enum
{
    public static class EnumExtension
    {
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attribs =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attribs != null && attribs.Any())
            {
                return attribs.First().Description;
            }
            return value.ToString();
        }

        public static Enum GetEnumValueFromDescription(Type enumToInvestigate, string descriptionToMatch)
        {
            Array enumValues = Enum.GetValues(enumToInvestigate);
            foreach (Enum enumValue in enumValues)
            {
                if (enumValue.GetEnumDescription() == descriptionToMatch)
                {
                    return enumValue;
                }
            }

            return (Enum)enumValues.GetValue(0);
        }


        public static Enum GetEnumValueFromText(Type enumToInvestigate, string text)
        {
            Array enumValues = Enum.GetValues(enumToInvestigate);

            foreach (Enum enumValue in enumValues)
            {
                if (enumValue.GetEnumDescription() == text || enumValue.ToString() == text)
                {
                    return enumValue;
                }
            }

            throw new InvalidOperationException($"The given description or name ({text}) was not found in {enumToInvestigate}");
        }


    }
}
