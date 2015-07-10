using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_ex_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            // build a car
            var carBuilder = new CarBuilder();

            BuildIt(shop, carBuilder);
            
            // build a motocycle
            var motorcycleBuilder = new MotocycleBuilder();

            BuildIt(shop, motorcycleBuilder);

            Console.ReadLine();
        }

        static void BuildIt(Shop shop, Builder builder)
        {
            shop.Construct(builder);

            var result = builder.GetResult();

            Console.WriteLine(result);
        }
    }
}
