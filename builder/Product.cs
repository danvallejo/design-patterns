namespace builder
{
    public class Product
    {
        private readonly string partsList;

        public Product(string partsList )
        {
            this.partsList = partsList;
        }

        public override string ToString()
        {
            return partsList;
        }
    }
}
