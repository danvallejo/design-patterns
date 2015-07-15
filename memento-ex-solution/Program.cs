using System.Collections.Generic;
using System.IO;

namespace memento_ex_solution
{
    public class DataLogger
    {
        private const string FileName = "datalog.txt";

        public DataLogger()
        {
            File.Delete(FileName);
        }

        public void Add(string line)
        {
            File.AppendAllText(FileName, line + "\n");
        }

        public Memento SaveToMemento()
        {
            return new Memento(FileName);
        }

        public void RestoreFromMemento(Memento memento)
        {
            File.Delete(FileName);
            File.AppendAllLines(FileName, memento.State);
        }
    }

    public class Memento
    {
        public Memento(string fileName)
        {
            State = File.ReadAllLines(fileName);
        }

        public string[] State
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
            var originator = new DataLogger();

            originator.Add("line 1");
            originator.Add("line 2");

            var caretaker = new Caretaker();
            caretaker.Add(originator.SaveToMemento());

            originator.Add("line 3");

            originator.RestoreFromMemento(caretaker.Get(0));
        }
    }
}
