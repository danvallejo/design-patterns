using System;
using System.Collections.Generic;

namespace command
{
    public class User
    {
        private Calculator calculator = new Calculator();
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void Compute(char @operator, int operand)
        {
            var command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();

            commands.Add(command);
            current++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine("Undo {0} levels", levels);
            for (var index = 0; index < levels; index++)
            {
                if (current > 0)
                {
                    var command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            Console.WriteLine("Redo {0} levels", levels);
            for (var index = 0; index < levels; index++)
            {
                if (current < commands.Count)
                {
                    var command = commands[current++];
                    command.Execute();
                }
            }
        }
    }
}
