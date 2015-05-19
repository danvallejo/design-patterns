namespace flyweight
{
    class Program
    {
        static void Main()
        {
            var factory = new FlyweightFactory();

            var flyweight1 = factory.GetFlyweight("A");
            var flyweight2 = factory.GetFlyweight("A");
            var flyweight3 = factory.GetFlyweight("B");

            flyweight1.Display();
            flyweight2.Display();
            flyweight3.Display();
        }
    }
}
