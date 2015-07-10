namespace adapter_ex_solution
{
    class Program
    {
        static void Main()
        {
            IClient target = new Client();

            target.Request();
        }
    }
}
