using System.Collections.Generic;

namespace observer
{
    /// <summary>
    /// The 'Subject' class
    /// </summary>
    abstract class Stock
    {
        private string symbol;
        private double price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }

        // Gets or sets the price
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }
    }
}