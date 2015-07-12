using System;

namespace proxy_ex
{
    class Program
    {
        static void Main()
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
