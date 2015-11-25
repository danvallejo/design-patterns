namespace strategy_ex_solution
{
    public interface ITaxCalculator
    {
        double CalculateTax(double subtotal);
    }

    public class WATaxCalculator : ITaxCalculator
    {
        public const double TaxRate = 10.0/100.0;

        public double CalculateTax(double subtotal)
        {
            return subtotal*TaxRate;
        }
    }
}