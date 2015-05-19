using System;

namespace flyweight
{
    public abstract class Flyweight
    {
        public string Symbol { get; set; }

        public int Width { get; set; }

        public virtual void Display()
        {
            Console.WriteLine(Symbol);
        }
    }

    public class FlyweightA : Flyweight
    {
        public FlyweightA()
        {
            Symbol = "A";
            Width = 8;
        }
    }

    public class FlyweightB : Flyweight
    {
        public FlyweightB()
        {
            Symbol = "B";
            Width = 10;
        }
    }
}
