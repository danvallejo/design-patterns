using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new Proxy();

            Console.WriteLine(proxy.Add(1, 2));
            Console.WriteLine(proxy.Sub(5, 2));
        }
    }
}
