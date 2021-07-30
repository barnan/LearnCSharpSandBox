using System;
using System.IO;

namespace GC_IDisposable
{
    public class Resource : IDisposable
    {
        private readonly byte[] state;                       // managelt -> nem IDisposable      -> ezekkel nem kell foglalkozni
        private StreamReader streamReader;          // managelt -> Disposable           ->
        // private void* unManagedState;            // nem managelt

        public Resource()
        {
            state = new byte[10000];
            streamReader = new StreamReader("");
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)      //szátmaztatásnál ezt overrideolni!!
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                streamReader?.Dispose();        // null ellenőrzés
            }

            // state = null;             // ezáltal, a byte tömb felszabadításánál nem kell megvárni a finalize-t, de végig kell gondolni, hogy a readonly vagy az e a fontosabb, hogy felszabadítsuk
            //free(unmanagedState)

            disposed = true;
        }

        public /*virtual*/ void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);      // ennek ellenére bekerül a fReachable-be, de a finailzer thread nem hívja meg a Finlize-t, hanem megy egyből a következő elemre a ugrik az fStream-ben
        }

        ~Resource()
        {
            Dispose(false); // nem manageltrészt a finalizerben szabadítom fel, de a determinisztikus felszabadításhoz a dispose-ba is belekerül
        }

        public void BusinessLoginc()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (Resource r = new Resource())
            {
            }
        }
    }
}