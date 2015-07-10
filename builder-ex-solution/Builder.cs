namespace builder_ex_solution
{
    public interface IBuilder
    {
        void BuildFrame();
        void BuildEngine();

        Product GetResult();
    }
}
