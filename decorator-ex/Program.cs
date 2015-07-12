using System;

namespace decorator_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new Remote();

            remote.Volume++;
            remote.Volume++;
            remote.Volume = 100;

            remote.ChangeChannel(10);

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
