
using System.Threading;

namespace Threading02
{
    internal class WaitHandleTest
    {
        AutoResetEvent _are = new AutoResetEvent(true);             // a WaitHandle-ek képesek blokkolni a Thread.Abortot is? Csak akkor fut le a Thread.Abort,
                                                                    // ha az (OS szintű) WaitHandle elengedte a szálat

        internal void Execute()
        {
            
        }
    }
}
