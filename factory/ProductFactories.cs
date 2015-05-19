namespace factory
{
    public abstract class ProductFactory
    {
        public abstract Product Create();
    }

    public class AppleFactory : ProductFactory
    {
        public override Product Create()
        {
            return new AppleProduct();
        }
    }

    public class BerryFactory : ProductFactory
    {
        public override Product Create()
        {
            return new BerryProduct();
        }
    }

    public class CherryFactory : ProductFactory
    {
        public override Product Create()
        {
            return new CherryProduct();
        }
    }
}
