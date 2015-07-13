using System;

namespace iterator_ex_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new ShapePool { "circle", "square", "triangle", "rectangle" };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.ReadLine();
        }
    }
}
