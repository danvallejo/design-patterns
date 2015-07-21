using System.IO;

namespace memento_ex_solution
{
    public class Memento
    {
        public object State
        {
            get;
            protected set;
        }
    }

    public class DataLoggerMemento : Memento
    {
        public DataLoggerMemento(string fileName)
        {
            State = File.ReadAllLines(fileName);
        }
    }
}
