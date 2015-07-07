using System;
using System.IO;
using System.Threading.Tasks;

namespace singleton_logger_ex
{
    class Program
    {
        static void Main()
        {
            const int maxThreads = 1000;

            File.Delete(FileLogger.FileName);

            Console.WriteLine("Start threads");

            Parallel.For(0, maxThreads, (index) =>
            {
                Console.WriteLine("Creating thread {0}", index);
                FileLogger.Instance.Log("In thread {0}", index);
            });

            Console.WriteLine("End");

            var lines = File.ReadAllLines(FileLogger.FileName);

            if (lines.Length != maxThreads)
            {
                Console.WriteLine("Threads ({0}) doesn't match lines written {1}", maxThreads, lines.Length);
            }

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
