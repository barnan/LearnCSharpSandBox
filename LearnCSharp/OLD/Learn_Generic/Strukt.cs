using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Generic
{
    internal struct Strukt <T>
    {
        public T MyProperty { get; set; }

        public Strukt(T myProperty)
        {
            MyProperty = myProperty;
        }
    }
}
