namespace prototype
{
    class Program
    {
        static void Main()
        {
            var c = new Concrete {Id = "1", Name = "one"};

            Concrete p = c.Clone() as Concrete;
        }
    }
}
