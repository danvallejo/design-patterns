namespace builder_ex_solution
{
    // Director
    public class Shop
    {
        public void Construct(Builder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
        }
    }
}
