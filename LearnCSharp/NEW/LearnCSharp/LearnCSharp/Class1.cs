using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Class1 : Interface1
    {
        public virtual string ValamiOverride()
        {
            return $"{nameof(Class1)}{nameof(ValamiOverride)}";
        }

        public virtual string ValamiNew()
        {
            return $"{nameof(Class1)}{nameof(ValamiNew)}";
        }
    }
}
