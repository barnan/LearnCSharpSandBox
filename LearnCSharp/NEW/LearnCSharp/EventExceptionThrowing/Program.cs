using System;

namespace EventExceptionThrowing
{
    class Program
    {
        static void Main(string[] args)
        {
            EventProvider ep = new EventProvider();
            //ep.Events1 += Ep_Events1;
            //ep.DoSomething1();

            CallExceptionThrowerMethod(ep);

            Console.WriteLine("Program finished");
            Console.ReadKey();
        }

        private static void Ep_Events1(object sender, string e)
        {
            //Console.WriteLine($"{nameof(Ep_Events1)} was called");
            throw new Exception("Súlyos hiba lépett fel!!!!!!!!!!!!!");
        }


        private static void CallExceptionThrowerMethod(EventProvider ep)
        {
            ep.DoSomething2();
        }

    }
}
