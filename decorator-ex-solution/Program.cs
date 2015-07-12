using System;

namespace decorator_ex_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new LoggingRemote(new Remote());

            remote.Volume++;
            remote.Volume++;
            remote.Volume = 100;

            remote.ChangeChannel(10);

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
