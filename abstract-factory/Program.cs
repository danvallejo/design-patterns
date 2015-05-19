namespace abstract_factory
{
    class Program
    {
        static void Main()
        {
            var client = new Client();

            client.AddToCart();
        }
    }
}
