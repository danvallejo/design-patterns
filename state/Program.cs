using System;

namespace state
{
    class Program
    {
        static void Main()
        {
            var vendingMachine = new VendingMachine();

            vendingMachine.DepositNickel();
            vendingMachine.DepositDime();
            vendingMachine.DepositNickel();
            vendingMachine.DepositNickel();
            vendingMachine.DepositNickel();

            Console.ReadLine();
        }
    }
}
