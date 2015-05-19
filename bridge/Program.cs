using System;

namespace bridge
{
    class Program
    {
        static void Main()
        {
            Abstraction abstraction = new MySmartTelevision();

            abstraction.Implementor = new CableTelevision();

            Console.WriteLine(abstraction.GetGuide());

            Console.WriteLine(abstraction.PlayVideo());
        }
    }
}
