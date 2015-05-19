namespace factory_solution
{
    public enum ProductType
    {
        Apple,
        Berry,
        Cherry,
    }

    public static class ProductFactory
    {
        public static Product Create(ProductType productType)
        {
            Product product = null;

            switch (productType)
            {
                case ProductType.Apple:
                    {
                        product = new AppleProduct();
                        break;
                    }
                case ProductType.Berry:
                    {
                        product = new BerryProduct();
                        break;
                    }
                case ProductType.Cherry:
                    {
                        product = new CherryProduct();
                        break;
                    }
            }

            return product;
        }
    }
}
