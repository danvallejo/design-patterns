namespace strategy_ex_solution
{
    public class WATaxCalculator : ITaxCalculator
    {
        public const double TaxRate = 10.0/100.0;

        public double CalculateTax(double subtotal)
        {
            return subtotal*TaxRate;
        }
    }
}