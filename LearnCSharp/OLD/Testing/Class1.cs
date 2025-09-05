using System;
using System.IO;

namespace Testing
{
    public class Class1
    {
        private const string TRACE_LOG_SUBFOLDER = "WaferContourMeter2";

        private static void Main(string[] args)
        {
            string folder1 = @".\Log\Alignment_log\";       // GetFullPath -> exe -hez relatív útvonalt épít
            string folder2 = @"\Log\Alignment_log\";        // GetFullPath -> gyökérből indulva építi fel
            string folder3 = @"Log\Alignment_log\";         // GetFullPath -> exe-hez képest relatívan építi fel az útvonalat

            string folder4 = @"C:\a0";
            string folder5 = "valami";

            string usedfolder = folder2;

            string path = Path.GetFullPath(Path.Combine(usedfolder, TRACE_LOG_SUBFOLDER + folder5));

            string path2 = Path.GetDirectoryName(usedfolder);

            var fileNameWoExtension = Path.GetFileNameWithoutExtension(usedfolder);

            var extension = Path.GetExtension(usedfolder);

            string comb1 = Path.Combine(folder4, folder1);
            string comb2 = Path.Combine(folder4, folder2);
            string comb3 = Path.Combine(folder4, folder3);

            Console.ReadKey();
        }
    }
}