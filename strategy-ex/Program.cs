using System;

namespace strategy_ex
{
    class Program
    {
        static void Main()
        {
            var order = new Order { State = "WA", Subtotal = 212.45 };

            Console.WriteLine("Order Subtotal = {0:c}", order.Subtotal);
            Console.WriteLine("Order Shipping = {0:c}", order.Shipping);
            Console.WriteLine("Order Tax      = {0:c}", order.Tax);

            Console.ReadLine();
        }
    }

    public class Order
    {
        public string State { get; set; }

        public double Subtotal { get; set; }

        public double Tax
        {
            get
            {
                var tax = 0.0;

                if (State == "WA")
                {
                    tax = 10.0;
                }

                return Subtotal * tax / 100.0;
            }
        }

        public double Shipping
        {
            get
            {
                var shippingRate = 0.0;

                if (Subtotal < 50.0)
                {
                    shippingRate = 10.0;
                }

                return Subtotal * shippingRate / 100.0;
            }
        }
    }
}
