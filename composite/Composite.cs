using System;
using System.Collections.Generic;

namespace composite
{
    public class Composite : Component
    {
        private List<Component> components = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Composite-{0}", Name);

            foreach (var child in components)
            {
                child.Draw();
            }
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}