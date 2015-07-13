using System;

namespace observer
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                              "change to {2:C}", _name, stock.Symbol, stock.Price);
        }
    }
}