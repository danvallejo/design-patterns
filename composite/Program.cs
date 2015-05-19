using System;

namespace composite
{
    class Program
    {
        static void Main()
        {
            var root = new Composite("picture");

            root.Add(new Leaf("Circle"));

            var twoCircles = new Composite("Two Circles");
            twoCircles.Add(new Leaf("Red Circle"));
            twoCircles.Add(new Leaf("Green Circle"));

            root.Add(twoCircles);

            root.Draw();

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
