namespace adapter
{
    public class Adapter
    {
        private readonly Adaptee adaptee;

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
