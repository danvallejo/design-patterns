namespace abstract_factory_solution
{
    public enum ProductType
    {
        Apple,
        Berry,
        Cherry,
    }

    public static class AbstractFactory
    {
        public static IFactory CreateFactory(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Apple:
                {
                    return new AppleFactory();
                }
                case ProductType.Berry:
                {
                    return new BerryFactory();
                }
                case ProductType.Cherry:
                {
                    return new CherryFactory();
                }
            }

            return null;
        }
    }

    public interface IFactory
    {
        Product Create();
    }

    public class AppleFactory : IFactory
    {
        internal AppleFactory()
        {
        }

        public Product Create()
        {
            return new AppleProduct();
        }
    }

    public class BerryFactory : IFactory
    {
        internal BerryFactory()
        {
        }

        public Product Create()
        {
            return new BerryProduct();
        }
    }

    public class CherryFactory : IFactory
    {
        internal CherryFactory()
        {
        }

        public Product Create()
        {
            return new CherryProduct();
        }
    }
}
