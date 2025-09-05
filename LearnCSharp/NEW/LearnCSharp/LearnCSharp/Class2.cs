using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Class2 : Class1, Interface1
    {

        public override string ValamiOverride()
        {
            return $"{nameof(Class2)}{nameof(ValamiOverride)}";
        }

        public new string ValamiNew()
        {
            return $"{nameof(Class2)}{nameof(ValamiNew)}";
        }
    }
}
