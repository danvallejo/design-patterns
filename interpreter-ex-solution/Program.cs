using System;
using System.Collections.Generic;
using System.Linq;

namespace interpreter_ex_solution
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
        public Context(string input)
        {
            Input = input;
            Stack = new Stack<int>();
        }

        public string Input { get; set; }

        public Stack<int> Stack { get; private set; }

        public int Output
        {
            get { return Stack.Peek(); }
        }
    }

    /// <summary>
    /// The 'AbstractExpression' class
    /// </summary>
    abstract class Expression
    {
        public abstract bool Interpret(Context context);
    }

    class NumberExpression : Expression
    {
        public override bool Interpret(Context context)
        {
             var parts = context.Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var currentToken =  parts[0];

            int result;
            if (int.TryParse(currentToken, out result))
            {
                context.Stack.Push(result);
                context.Input = string.Join(" ", parts.Skip(1));
                return true;
            }

            return false;
        }
    }

    class PlusExpression : Expression
    {
        public override bool Interpret(Context context)
        {
            var parts = context.Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var currentToken = parts[0];

            if (currentToken == "+")
            {
                var y = context.Stack.Pop();
                var x = context.Stack.Pop();

                context.Stack.Push(x + y);

                context.Input = string.Join(" ", parts.Skip(1));
                return true;
            }

            return false;
        }
    }

    class MinusExpression : Expression
    {
        public override bool Interpret(Context context)
        {
            var parts = context.Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var currentToken = parts[0];

            if (currentToken == "-")
            {
                var y = context.Stack.Pop();
                var x = context.Stack.Pop();

                context.Stack.Push(x - y);

                context.Input = string.Join(" ", parts.Skip(1));
                return true;
            }

            return false;
        }
    }

    public class RPNEvaluator
    {
        public static int Evaluate(string rpn)
        {
            var context = new Context(rpn);

            // Build the 'parse tree'
            // expression ::= number | plus | minus
            // plus ::= expression expression '+'
            // minus ::= expression expression '-'
            // digit = '0' | '1' | ... | '9'
            // number ::= digit | digit number

            var expressions = new List<Expression>
            {
                new NumberExpression(),
                new PlusExpression(),
                new MinusExpression(),
            };

            // Interpret
            while (context.Input.Length > 0)
            {
                bool infiniteLoop = true;

                foreach (var expression in expressions)
                {
                    if (expression.Interpret(context))
                    {
                        infiniteLoop = false;
                        break;
                    }
                }

                if (infiniteLoop)
                {
                    throw new Exception("Invalid token in expression :"+ context.Input);
                }
            }

            return context.Output;
        }
    }

    class Program
    {
        static void Main()
        {
            const string rpn = "4 2 - 1 +";

            Console.WriteLine("{0} = {1}", rpn, RPNEvaluator.Evaluate(rpn));

            Console.ReadLine();
        }
    }
}
