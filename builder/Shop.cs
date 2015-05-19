namespace builder
{
    // Director
    public class Shop
    {
        public void Construct(Builder builder)
        {
            builder.BuildEngine();
            builder.BuildFrame();
        }
    }
}
