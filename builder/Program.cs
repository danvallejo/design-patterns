using System;

namespace builder
{
    class Program
    {
        static void Main()
        {
            var shop = new Shop();

            var carBuilder = new CarBuilder();

            shop.Construct(carBuilder);

            var result = carBuilder.GetResult();

            Console.WriteLine(result);
        }
    }
}
