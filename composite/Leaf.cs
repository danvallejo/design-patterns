using System;

namespace composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Leaf-{0}", Name);
        }
    }
}