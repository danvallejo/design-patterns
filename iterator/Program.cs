using System;

namespace iterator
{
    class Program
    {
        static void Main()
        {
            var connectionPools = new ConnectionPools { "SqlServer", "Oracle", "Postgress" };

            foreach (var pool in connectionPools)
            {
                Console.WriteLine(pool);
            }

            Console.ReadLine();
        }
    }
}
