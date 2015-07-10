namespace builder_ex_solution
{
    // Director
    public class Shop
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
        }
    }
}
