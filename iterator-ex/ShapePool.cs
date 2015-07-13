using System.Collections;
using System.Collections.Generic;

namespace iterator_ex
{
    public class ShapePool
    {
        private List<string> shapes = new List<string>();

        public void Add(string shape)
        {
            shapes.Add(shape);
        }
    }
}
