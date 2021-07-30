namespace Learn_Interface
{
    internal interface IInterface02
    {
        protected abstract void Valami();

        public void DoSomething02();

        void DoSomething02_2()
        {
            System.Console.WriteLine("Default implementation");
        }
    }
}