using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_ex_solution
{
    class Program
    {
        static void Main()
        {
            var vm = new VendingMachine();

            vm.ProductAmount = 50;

            vm.DepositQuarter();
            vm.DepositQuarter();
            vm.DepositQuarter();
            vm.DepositQuarter();

            Console.Write("Done");
            Console.ReadLine();
        }
    }
}
