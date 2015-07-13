namespace strategy_ex_solution
{
    public interface IShippingCalculator
    {
        double CalculateShipping(double subtotal);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public double CalculateShipping(double subtotal)
        {
            var shippingRate = 0.0;

            if (subtotal < 50.0)
            {
                shippingRate = 10.0;
            }

            return subtotal * shippingRate / 100.0;
        }
    }
}