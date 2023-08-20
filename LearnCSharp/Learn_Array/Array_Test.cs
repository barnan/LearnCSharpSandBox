using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Array
{
    internal static class Array_Test
    {
        internal static void Test()
        {
            ArrayList arrayList = new ArrayList() { 1, "cica", null, 2f };
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);        // a null üres lesz
            }


            Queue queue = new Queue(30);
            queue.Enqueue("haha");
            queue.Enqueue("haha");
            queue.Enqueue(10);

            Queue<int> intQueue = new Queue<int>(10);           // ez típusos, ebbe csak int- et lehet tenni
            intQueue.Enqueue(2);
            intQueue.Enqueue(1);
            intQueue.Enqueue(10);

            Console.WriteLine($"queue is synchronized? {queue.IsSynchronized}");
            object syncObject = queue.SyncRoot;     // ez használható bárhol ahol ezt a kollekciót használjuk

            Collection<int> koll = new Collection<int>();

            Hashtable hashTable = new Hashtable();
        }
    }
}
