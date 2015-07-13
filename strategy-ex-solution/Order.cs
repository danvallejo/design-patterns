namespace strategy_ex_solution
{
    public class Order
    {
        public string State { get; set; }

        public double Subtotal { get; set; }

        public double CalculateTax(ITaxCalculator taxCalculator)
        {
            return taxCalculator.CalculateTax(Subtotal);
        }

        public double CalculateShipping(IShippingCalculator shippingCalculator)
        {
            return shippingCalculator.CalculateShipping(Subtotal);
        }
    }
}