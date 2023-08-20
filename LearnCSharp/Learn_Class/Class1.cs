using System.IO;

namespace Learn_Class
{
    internal abstract class Class1
    {
        public int _field1 = 10;
        public int _field2 = 20;
        public string _str1 = "text1";

        public Class1(int in1, int in2, string in3)
        {
            _field1 = in1;
            _field2 = in2;
            _str1 = in3;
        }

        private int myfield;
        public int MyProperty
        {
            get { return myfield; }
            set { myfield = value; }
            //init { myfield = value; }
        }

        public abstract void DoSomething();
        public virtual void DoSomething_2() 
        { 
        }
    }
}
