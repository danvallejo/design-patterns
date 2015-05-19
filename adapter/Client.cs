namespace adapter
{
    public class Client
    {
        private Adapter adapter;

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
