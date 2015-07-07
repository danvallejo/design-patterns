using System;

namespace facade_ex_solution
{
    // Legacy code that cannot be modified
    public class DateFormat
    {
        public DateFormat(int seed)
        {
        }

        public string FormatDate(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
    }

    public class IntFormatter
    {
        public string IntFormat(int v)
        {
            return v.ToString("#,###");
        }
    }

    public static class Money
    {
        public static string FormatCurrency(double v)
        {
            return v.ToString("C");
        }
    }

    // Facade
    public class Formatter
    {
        private static DateFormat dateFormatter;
        private static IntFormatter intFormatter;

        static Formatter()
        {
            // "new" can be bad. It doesn't allow for dependency injection.
            dateFormatter = new DateFormat(2);
            intFormatter = new IntFormatter();
        }

        public static string ToString(DateTime dateTime)
        {
            return dateFormatter.FormatDate(dateTime);
        }

        public static string ToString(int number)
        {
            return intFormatter.IntFormat(number);
        }

        public static string ToString(double number)
        {
            return Money.FormatCurrency(number);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date is {0}", Formatter.ToString(DateTime.Now));

            Console.WriteLine("Value is {0}", Formatter.ToString(123));

            Console.WriteLine("Money is {0}", Formatter.ToString(1234567.89));

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
