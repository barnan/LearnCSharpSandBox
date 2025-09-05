namespace Async_Await
{
    internal static class AsyncAwaitTest
    {
        //internal static void LoadConfigurationToDevice()
        //{
        //    Console.WriteLine($"Starting the {nameof(LoadConfigurationToDevice)}");

        //    Task.Delay(_WAIT_TIME_MS);

        //    Console.WriteLine($"Finishing the {nameof(LoadConfigurationToDevice)}");
        //}


        internal static async Task<bool> LoadConfigurationToDeviceAsync(int waitTimeMs)
        {
            Console.WriteLine($"Starting the {nameof(LoadConfigurationToDeviceAsync)}");

            await Task.Delay(waitTimeMs);

            Console.WriteLine($"Finishing the {nameof(LoadConfigurationToDeviceAsync)}");

            return true;        // a konfig rátöltés sikeres volt
        }

        internal static void LoadConfigurationToDeviceThread(int waitTimeMs)
        {
            Thread t = new Thread(() =>
            {
                Console.WriteLine($"Starting the {nameof(LoadConfigurationToDeviceThread)}");

                Thread.Sleep(waitTimeMs);

                Console.WriteLine($"Finishing the {nameof(LoadConfigurationToDeviceThread)}");
            })
            {
                IsBackground = false
            };

            t.Start();
        }
    }
}
