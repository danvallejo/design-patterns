using System;

namespace proxy_ex_solution
{
    class Program
    {
        static void Main()
        {
            IRemote remote = new RemoteProxy();

            remote.Volume++;
            remote.Volume++;
            remote.Volume = 100;

            remote.ChangeChannel(10);

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
