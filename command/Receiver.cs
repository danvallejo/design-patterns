using System;

namespace command
{
    // Receiver (Context)
    public class Receiver
    {
        private int currentValue = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                {
                    currentValue += operand;
                    break;
                }
                case '-':
                {
                    currentValue -= operand;
                    break;
                }
                case '*':
                {
                    currentValue *= operand;
                    break;
                }
                case '/':
                {
                    currentValue /= operand;
                    break;
                }
            }
            Console.WriteLine("Current value is {0,4} (following {1} {2}", currentValue, @operator, operand);
        }
    }
}
