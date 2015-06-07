using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsEx
{
    public class SingletonThread
    {
        private static SingletonThread singleton;

        private static object sync = new object();

        private SingletonThread()
        {
        }

        public static SingletonThread Instance
        {
            get
            {
                if (singleton == null)
                {
                    lock (sync)
                    {
                        Thread.Sleep(1);
                        if (singleton == null) // Comment this line out and see what happens in
                        {
                            singleton = new SingletonThread();
                        }
                    }
                }
                return singleton;
            }
        }
    }


    class Program
    {
        static void Main()
        {
            const int maxThreads = 1000;
            var singletons = new SingletonThread[maxThreads];

            Console.WriteLine("Start");

            Parallel.For(0, maxThreads, (threadIndex) =>
            {
                Console.WriteLine("Creating {0}", threadIndex);
                singletons[threadIndex] = SingletonThread.Instance;
            });

            Console.WriteLine("End");

            for (var threadIndex = 0; threadIndex < maxThreads; threadIndex++)
            {
                for (var compIndex = threadIndex; compIndex < maxThreads; compIndex++)
                {
                    if (singletons[threadIndex] != singletons[compIndex])
                    {
                        Console.WriteLine("Error {0} does not match {1}", threadIndex, compIndex);
                    }
                }
            }

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
