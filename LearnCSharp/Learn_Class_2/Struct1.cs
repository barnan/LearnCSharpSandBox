
namespace Learn_Class_2
{
    internal class Struct1
    {
        static int _macika;

        static Struct1()
        {
            Console.WriteLine("Static constructor");
            _macika = 1;
        }

        public Struct1()
        {
            Console.WriteLine("Instance constructor");
            _macika = 3;
        }

        internal static void DoSomething()
        {
            Console.WriteLine($"Static DoSomething: {_macika}");
        }

    }
}
