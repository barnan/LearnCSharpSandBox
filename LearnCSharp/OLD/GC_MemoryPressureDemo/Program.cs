using System;

namespace GC_MemoryPressureDemo
{
    // okafogyott ez a szituáció, merrt dispose mintát kellene használni itt a REsource-ban és az ezt a heckelést feleslegessé teszi.

    public class Resource
    {
        //tegyük fel, hogy sok nem managelt erőforrást használ, manageltből pedig csak keveset

        public Resource()
        {
            // call unmanaged code, allocate unmanaged resource
            GC.AddMemoryPressure(10000000);     // nagy nem managelt memória területet foglal
        }

        ~Resource()
        {
            Console.WriteLine("Object finalized");
            GC.RemoveMemoryPressure(10000000);      //
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                new Resource();             // unrooted-ként vannak definiálva
            }

            Console.WriteLine("Objects created");
            Console.ReadLine();
        }
    }
}