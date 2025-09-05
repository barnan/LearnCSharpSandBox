using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GC_Notification
{
    // csak blokkoló hívásokról értesít, non-concurent GC esetén működhet
    internal class Program
    {
        private static void Main(string[] args)
        {
            GC.RegisterForFullGCNotification(90, 90);       // SOH gen2 és LOP értesítési threshold százaléka

            Task.Run(() =>
            {
                while (true)
                {
                    var s2 = GC.WaitForFullGCApproach();     // arról értesítést, hogy nemsokára jön egy GC
                    if (s2 == GCNotificationStatus.Succeeded)
                    {
                        Console.WriteLine("Nemsokára jön");
                    }

                    var s = GC.WaitForFullGCComplete();
                    if (s == GCNotificationStatus.Succeeded)
                    {
                        Console.WriteLine("Succeeded");
                    }
                    else if (s == GCNotificationStatus.Canceled)
                    {
                        break;      // itt már vki valószínűleg leállította
                    }
                }
            });

            List<byte[]> tombok = new List<byte[]>();
            while (true)
            {
                tombok.Add(new byte[10000]);
            }

            // GC.CancelFullGCNotification();       // mintha leíratkozna
        }
    }
}