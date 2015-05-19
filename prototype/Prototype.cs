namespace prototype
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Concrete : Prototype
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override Prototype Clone()
        {
            return MemberwiseClone() as Concrete;
        }
    }
}
