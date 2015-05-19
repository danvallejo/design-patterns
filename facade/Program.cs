using System;

namespace facade
{
    class Program
    {
        static void Main()
        {
            // Facade
            var mortgage = new Mortgage();

            var customer = new Customer { Name = "Lisa Johnson" };

            // Evaluate mortgage eligibility for customer
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("{0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
