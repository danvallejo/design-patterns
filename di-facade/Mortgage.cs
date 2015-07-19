namespace di_facade
{
    public class Mortgage
    {
        private readonly Bank _bank;
        private readonly Loan _loan;
        private readonly Credit _credit;

        public Mortgage(Bank bank, Loan loan, Credit credit)
        {
            _bank = bank;
            _loan = loan;
            _credit = credit;
        }

        public bool IsEligible(Customer cust, int amount)
        {
            var eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
