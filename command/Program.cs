using System;

namespace command
{
    class Program
    {
        static void Main()
        {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 25);
            user.Compute('*', 2);
            user.Compute('/', 3);

            user.Undo(2);

            user.Redo(3);

            Console.ReadLine();
        }
    }
}
