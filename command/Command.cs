using System;

namespace command
{
    // The actual parameters
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    public class CalculatorCommand : Command
    {
        private Receiver calculator;
        private char @operator;
        private int operand;

        public CalculatorCommand(Receiver calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }
}
