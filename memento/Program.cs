using System.Collections.Generic;
using System.Linq;

namespace memento
{
    public class Originator
    {
        private List<string> users = new List<string>();

        public void Add(string user)
        {
            users.Add(user);
        }

        public Memento SaveToMemento()
        {
            return new Memento(users);
        }

        public void RestoreFromMemento(Memento memento)
        {
            users = memento.State.ToList();
        }
    }

    public class Memento
    {
        public Memento(IEnumerable<string> users)
        {
            State = users.ToList();
        }

        public IEnumerable<string> State
        {
            get;
            private set;
        }
    }

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

    class Program
    {
        static void Main()
        {
            var originator = new Originator();

            originator.Add("dave");
            originator.Add("mike");

            var caretaker = new Caretaker();
            caretaker.Add(originator.SaveToMemento());

            originator.Add("lisa");

            originator.RestoreFromMemento(caretaker.Get(0));
        }
    }
}
