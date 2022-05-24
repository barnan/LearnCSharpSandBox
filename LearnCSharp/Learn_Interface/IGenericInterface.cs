using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_Interface
{
    interface IGenericInterface
    {

        T Read<T>();
    }
}
