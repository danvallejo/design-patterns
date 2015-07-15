using System;
using System.Collections.Generic;

namespace interpreter_ex
{
    public class RPNEvaluator
    {
        public static int Evaluate(string rpn)
        {
            //var context = new Context(rpn);

            //// Build the 'parse tree'
            //// expression ::= number | plus | minus
            //// plus ::= expression expression '+'
            //// minus ::= expression expression '-'
            //// digit = '0' | '1' | ... | '9'
            //// number ::= digit | digit number

            //var expressions = new List<Expression>
            //{
            //    new NumberExpression(),
            //    new PlusExpression(),
            //    new MinusExpression(),
            //};

            //// Interpret
            //while (context.Input.Length > 0)
            //{
            //    bool infiniteLoop = true;

            //    foreach (var expression in expressions)
            //    {
            //        if (expression.Interpret(context))
            //        {
            //            infiniteLoop = false;
            //            break;
            //        }
            //    }

            //    if (infiniteLoop)
            //    {
            //        throw new Exception("Invalid token in expression :" + context.Input);
            //    }
            //}

            //return context.Output;
            return -1;
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
