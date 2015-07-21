using System.Collections.Generic;

namespace memento_ex_solution
{
    public class Caretaker
    {
        private readonly List<Memento> mementos;

        public Caretaker()
        {
            mementos = new List<Memento>();
        }

        public void Add(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento Get(int index)
        {
            return mementos[index];
        }
    }
}
