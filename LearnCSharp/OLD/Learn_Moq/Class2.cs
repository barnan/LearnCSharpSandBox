using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Moq
{
    class Class2 : Interface2
    {
        private Interface1 _interface1;

        public int DoSomething()
        {
            return _interface1.GetLength();
        }

        public Class2(Interface1 interface1)
        {
            _interface1 = interface1;
        }
    }
}
