using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Dictionary
{
    public class Class1
    {
        private static void Main(string[] args)
        {
            
            Dictionary<string, MyEnum> dict = new Dictionary<string, MyEnum>(3) { { "0", MyEnum.MyEnum1 }, { "1", MyEnum.MyEnum2 }, { "2", MyEnum.MyEnum3 } };

            var valami = dict.ElementAt(1);

            Console.ReadKey();
        }

    }

    public enum MyEnum
    {
        MyEnum1,
        MyEnum2,
        MyEnum3
    }

}
