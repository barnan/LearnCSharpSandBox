using System;

namespace LearnEmgu
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllocationTest.Test();

            StrideTest.Test();

            TryFinallyTest.Test();

            Console.ReadKey();
        }
    }



    //public static class GCMemoryInfoExtensions
    //{
    //    public static string WriteContent(this GCMemoryInfo info)
    //    {
    //        return $"FragmentedBytes: {info.FragmentedBytes}{Environment.NewLine}" +
    //               $"HeapSizeBytes: {info.HeapSizeBytes}{Environment.NewLine}" +
    //               $"HighMemoryLoadThresholdBytes: {info.HighMemoryLoadThresholdBytes}{Environment.NewLine}" +
    //               $"MemoryLoadBytes: {info.MemoryLoadBytes}{Environment.NewLine}" +
    //               $"TotalAvailableMemoryBytes: {info.TotalAvailableMemoryBytes}";
    //    }
    //}

}
