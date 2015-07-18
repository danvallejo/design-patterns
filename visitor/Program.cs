using System;

namespace visitor
{
    class Program
    {
        static void Main()
        {
            var e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            Console.ReadLine();
        }
    }
}
