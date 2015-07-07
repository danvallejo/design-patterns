using System;

namespace facade_ex
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
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date is {0}", new DateFormat(2).FormatDate(DateTime.Now));

            Console.WriteLine("Value is {0}", new IntFormatter().IntFormat(123));

            Console.WriteLine("Money is {0}", Money.FormatCurrency(1234567.89));

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
