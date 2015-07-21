using System.Collections.Generic;
using System.IO;

namespace memento_ex_solution
{
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
