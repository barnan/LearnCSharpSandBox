namespace Learn_Interface
{
    internal partial struct Struct1
    {
        public int k;              // nem lehet mezőinicializálót használni structban
        public static int D;

        partial void Method01(ref int k);

        public void Method02()
        {
            System.Console.WriteLine("Method02");
            k = 10;
            Method01(ref k);
        }
    }

    internal partial struct Struct1
    {
        public Struct1(int b)
        {
            k = b;
        }

        public Struct1(Struct1 input)
        {
            this = input;
        }

        partial void Method01(ref int g)
        {
            System.Console.WriteLine($"Kiir valamit partial method01-1 {g = 40}");
        }
    }
}