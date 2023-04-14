using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ToString
{
    internal class ProcessFlow2
    {

        public string Name { get; set; }

        public static bool operator ==(ProcessFlow2 p1, ProcessFlow2 p2)
        {
            return true;
        }

        public static bool operator !=(ProcessFlow2 p1, ProcessFlow2 p2)
        {
            return !(p1 == p2);
        }
    }
}
