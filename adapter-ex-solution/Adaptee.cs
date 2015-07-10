namespace adapter_ex_solution
{
    public interface IAdaptee
    {
        void SpecificRequest();
    }

    public class Adaptee : IAdaptee
    {
        public void SpecificRequest()
        {
        }
    }
}
