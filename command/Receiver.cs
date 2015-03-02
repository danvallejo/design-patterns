using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class Calculator
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
