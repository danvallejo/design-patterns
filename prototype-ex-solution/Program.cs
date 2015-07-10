namespace prototype_ex_solution
{
    class Program
    {
        static void Main()
        {
            var myConcrete = new Concrete { Id = "1", Name = "one" };

            var anotherConcrete = myConcrete.Clone();
        }
    }
}
