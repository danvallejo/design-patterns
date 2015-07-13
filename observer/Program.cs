using System;

namespace observer
{
    class Program
    {
        static void Main()
        {
            var stock = new IBM(100.0);

            var dave = new Investor("dave");
            var mike = new Investor("mike");

            stock.Attach(dave);
            stock.Attach(mike);

            stock.Price = 101.0;
            stock.Price = 102.0;

            stock.Detach(dave);

            stock.Price = 98.0;

            Console.ReadLine();
        }
    }
}
