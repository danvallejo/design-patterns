namespace observer
{
    /// <summary>
    /// Concrete Subject
    /// </summary>
    class IBM : Stock
    {
        public IBM(double price)
            : base("IBM", price)
        {
        }
    }
}