namespace adapter_ex_solution
{
    public interface IClient
    {
        void Request();
    }

    public class Client : IClient
    {
        private IAdapter adapter;

        public Client()
        {
            adapter = new Adapter();
        }

        public void Request()
        {
            adapter.Request();
        }
    }
}
