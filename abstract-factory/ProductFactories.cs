namespace abstract_factory
{
    public static class AbstractFactory
    {
        public static IFactory CreateFactoryApple()
        {
            return new AppleFactory();
        }

        public static IFactory CreateFactoryBerry()
        {
            return new BerryFactory();
        }

        public static IFactory CreateFactoryCherry()
        {
            return new CherryFactory();
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
