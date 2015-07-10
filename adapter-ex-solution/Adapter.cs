namespace adapter_ex_solution
{
    interface IAdapter
    {
        void Request();
    }

    public class Adapter : IAdapter
    {
        private readonly IAdaptee adaptee;

        public Adapter()
        {
            adaptee = new Adaptee();
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
