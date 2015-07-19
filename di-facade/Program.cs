using System;

namespace di_facade
{
    class Program
    {
        static void Main()
        {
            // Facade
            var mortgage = AutofacContainer.Resolve<Mortgage>();

            var customer = AutofacContainer.Resolve<Customer>();
            customer.Name = "Lisa Johnson";

            // Evaluate mortgage eligibility for customer
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("{0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
