using System;
using System.Threading.Tasks;

namespace EventExceptionThrowing
{
    class EventProvider
    {
        internal event EventHandler<string> Events1;

        internal void DoSomething1()
        {
            Console.WriteLine($"{nameof(DoSomething1)} started");
            
            Task.Factory.StartNew(
                () => {
                    Task.Delay(1000);
                    Console.WriteLine($"{nameof(DoSomething1)} - Event will be called");
                    try
                    {
                        Events1.Invoke(this, "valami üzenet");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Exception jött vissza az event elsütőjéhez");
                    }
                    Console.WriteLine($"{nameof(DoSomething1)} - Event was called");
                }
            );
            Console.WriteLine($"{nameof(DoSomething1)} ended");
        }


        internal void DoSomething2()
        {
            throw new Exception();
        }

    }
}
