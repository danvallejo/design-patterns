using System;

namespace command
{
    class Program
    {
        static void Main()
        {
            var invoker = new Invoker();

            invoker.Compute('+', 100);
            invoker.Compute('-', 25);
            invoker.Compute('*', 2);
            invoker.Compute('/', 3);

            invoker.Undo(2);

            invoker.Redo(3);

            Console.ReadLine();
        }
    }
}
