using System;

namespace flyweight_ex_solution
{
    public interface IFlyweight
    {
        string Symbol { get; set; }

        int Width { get; set; }

        void Display();
    }

    public class FlyweightBase : IFlyweight
    {
        public FlyweightBase(string symbol, int width)
        {
            Symbol = symbol;
            Width = width;
        }

        public string Symbol
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public void Display()
        {
            Console.WriteLine(Symbol);
        }
    }

    public class FlyweightA : FlyweightBase
    {
        public FlyweightA() : base("A", 8)
        {
        }       
    }

    public class FlyweightB : FlyweightBase
    {
        public FlyweightB() : base("B", 10)
        {
        }
    }
}
