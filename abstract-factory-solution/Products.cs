namespace abstract_factory_solution
{
    public abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class AppleProduct : Product
    {
        public AppleProduct()
        {
            Name = "apple";
            Price = .25f;
        }
    }

    public class BerryProduct : Product
    {
        public BerryProduct()
        {
            Name = "berry";
            Price = .15f;
        }
    }

    public class CherryProduct : Product
    {
        public CherryProduct()
        {
            Name = "cherry";
            Price = .10f;
        }
    }
}
