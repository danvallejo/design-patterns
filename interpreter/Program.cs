using System;
using System.Collections.Generic;

namespace interpreter
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }

        public int Output { get; set; }
    }

    /// <summary>
    /// The 'AbstractExpression' class
    /// </summary>
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine))
            {
                context.Output += (9 * Multiplier);
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four))
            {
                context.Output += (4 * Multiplier);
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five))
            {
                context.Output += (5 * Multiplier);
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One))
            {
                context.Output += (1 * Multiplier);
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One { get; }
        public abstract string Four { get; }
        public abstract string Five { get; }
        public abstract string Nine { get; }
        public abstract int Multiplier { get; }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Thousand checks for the Roman Numeral M 
    /// </remarks>
    /// </summary>
    class ThousandExpression : Expression
    {
        public override string One { get { return "M"; } }
        public override string Four { get { return " "; } }
        public override string Five { get { return " "; } }
        public override string Nine { get { return " "; } }
        public override int Multiplier { get { return 1000; } }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Hundred checks C, CD, D or CM
    /// </remarks>
    /// </summary>
    class HundredExpression : Expression
    {
        public override string One { get { return "C"; } }
        public override string Four { get { return "CD"; } }
        public override string Five { get { return "D"; } }
        public override string Nine { get { return "CM"; } }
        public override int Multiplier { get { return 100; } }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Ten checks for X, XL, L and XC
    /// </remarks>
    /// </summary>
    class TenExpression : Expression
    {
        public override string One { get { return "X"; } }
        public override string Four { get { return "XL"; } }
        public override string Five { get { return "L"; } }
        public override string Nine { get { return "XC"; } }
        public override int Multiplier { get { return 10; } }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
    /// </remarks>
    /// </summary>
    class OneExpression : Expression
    {
        public override string One { get { return "I"; } }
        public override string Four { get { return "IV"; } }
        public override string Five { get { return "V"; } }
        public override string Nine { get { return "IX"; } }
        public override int Multiplier { get { return 1; } }
    }

    class Program
    {
        static void Main()
        {
            const string roman = "MCMXXVIII";
            var context = new Context(roman);

            // Build the 'parse tree'
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret
            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            Console.ReadLine();
        }
    }
}
