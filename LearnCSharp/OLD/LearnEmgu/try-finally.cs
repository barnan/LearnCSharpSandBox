using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnEmgu
{
    class TryFinallyTest
    {
        private static object _initLock = new object();
        private static bool _initialized = false ;

        public static void Test()
        {
            Monitor.Enter(_initLock);

            if (_initialized)
            {
                Monitor.Exit(_initLock);
            }

            try
            {
                _initialized = true;
                throw new Exception("HeHe");
            }
            catch (Exception e)
            {
                ;
            }
            finally
            {
                Monitor.Exit(_initLock);
            }
        }
    }
}
