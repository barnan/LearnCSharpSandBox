namespace Learn_Interface
{
    internal class Class2 : IInterface02
    {
        public void DoSomething02()
        {
            System.Console.WriteLine("Class2 - DoSomething02");
        }

        public virtual void DoSomething02_2()
        {
            System.Console.WriteLine("Class2 - DoSomething02_2 - virtual");
        }

        void IInterface02.Valami()
        {
            throw new System.NotImplementedException();
        }
    }
}