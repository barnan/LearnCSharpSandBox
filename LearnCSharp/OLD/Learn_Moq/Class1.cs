using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Moq
{
    class Class1 : Interface1
    {
        private string _name = "Class1";
        private int _intValue;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int IntValue
        {
            get => _intValue;
            set => _intValue = value;
        }

        public int GetLength()
        {
            return Name.Length;
        }

        public Class1(int intvalue)
        {
            IntValue = intvalue;
        }
    }
}
