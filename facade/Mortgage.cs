namespace facade
{
    public class Mortgage
    {
        private readonly Bank bank = new Bank();
        private readonly Loan loan = new Loan();
        private readonly Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            var eligible = true;

            // Check creditworthyness of applicant
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
