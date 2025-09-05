// See https://aka.ms/new-console-template for more information



namespace Async_Await
{
    internal class Program
    {
        private static int _INTERNAL_WAIT_TIME_BASE_MS = 1000;
        private static int _EXTERNAL_WAIT_TIME_BASE_MS = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            OldMegAProblemat_2();
        }



        static async Task OldMegAProblemat_1()
        {
            int maxCounter = 10;
            int counter = 0;

            Task<bool> loadTask = AsyncAwaitTest.LoadConfigurationToDeviceAsync(5 * _INTERNAL_WAIT_TIME_BASE_MS);
            

            while (counter++ < maxCounter)
            {
                Thread.Sleep(_EXTERNAL_WAIT_TIME_BASE_MS);
                Console.WriteLine($"Elapsed time: {counter * _EXTERNAL_WAIT_TIME_BASE_MS}ms");
            }

            bool result = await loadTask;

            Console.WriteLine($"Configuration loading was {(result ? "successful" : "not successful")}");
        }


        static void OldMegAProblemat_2()
        {
            int maxCounter = 10;
            int counter = 0;


            AsyncAwaitTest.LoadConfigurationToDeviceThread(5 * _INTERNAL_WAIT_TIME_BASE_MS);

            while (counter++ < maxCounter)
            {
                Thread.Sleep(_EXTERNAL_WAIT_TIME_BASE_MS);
                Console.WriteLine($"Elapsed time: {counter * _EXTERNAL_WAIT_TIME_BASE_MS}ms");
            }

            Console.WriteLine("Configuration loading was successful");
        }

        
    }
}
