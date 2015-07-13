using System.Collections;
using System.Collections.Generic;

namespace iterator_ex_solution
{
    public class ShapePool : IEnumerable<string>
    {
        private readonly List<string> shapes = new List<string>();

        public void Add(string shape)
        {
            shapes.Add(shape);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return shapes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
