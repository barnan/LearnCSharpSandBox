using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Interface_2
{
    internal class Class_01 : IInterface_01
    {

        private EventHandler _propEventHandler;


        private string _prop1;
        public string Prop1
        {
            get => _prop1;
            set => _prop1 = value;
        }


        private int _prop2;
        public int Prop2
        {
            get => _prop2;
            set => _prop2 = value;
        }


        public int this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }


        public int Method1(int input)
        {
            return 4000;
        }

        public EventHandler PropEventHandler
        {
            get => _propEventHandler;
            set => _propEventHandler = value;
        }


        public event EventHandler<MyEventArgs>? ThresholdReached;



    }
}
