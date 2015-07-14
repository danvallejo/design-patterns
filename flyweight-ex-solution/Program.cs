using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight_ex_solution
{
    class Program
    {
        static void Main()
        {
            var factory = FlyweightFactory.Instance;

            var flyweight1 = factory.GetFlyweight("A");
            var flyweight2 = factory.GetFlyweight("A");
            var flyweight3 = factory.GetFlyweight("B");

            flyweight1.Display();
            flyweight2.Display();
            flyweight3.Display();
        }
    }
}
