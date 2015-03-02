using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class ConnectionPools : IEnumerable<string>, IEnumerator<string>
    {
        private List<string> pools = new List<string>();

        public void Add(string pool)
        {
            pools.Add(pool);
        }

        public IEnumerator<string> GetEnumerator()
        {
            index = -1;

            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            index = -1;

            return this;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return (index < pools.Count);
        }

        private int index;

        public void Reset()
        {
            // THIS NEVER GET'S CALLED
            index = -1;
        }

        public string Current
        {
            get { return pools[index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}