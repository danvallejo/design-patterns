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
            return new DataLoggerMemento(FileName);
        }

        public void RestoreFromMemento(Memento memento)
        {
            File.Delete(FileName);
            File.AppendAllLines(FileName, (string[])memento.State);
        }
    }
}
