using System;

namespace strategy_ex_solution
{
    class Program
    {
        static void Main()
        {
            var order = new Order { State = "WA", Subtotal = 212.45 };

            Console.WriteLine("Order Subtotal = {0:c}", order.Subtotal);
            Console.WriteLine("Order Shipping = {0:c}", order.CalculateShipping(new ShippingCalculator()));
            Console.WriteLine("Order Tax      = {0:c}", order.CalculateTax(new WATaxCalculator()));

            Console.ReadLine();
        }
    }
}
