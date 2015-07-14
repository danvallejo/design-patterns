using System;

namespace flyweight_ex_solution
{
    public interface IFlyweight
    {
        string Symbol { get; set; }

        int Width { get; set; }

        void Display();

    }

    public class FlyweightA : IFlyweight
    {
        public FlyweightA()
        {
            Symbol = "A";
            Width = 8;
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

    public class FlyweightB : IFlyweight
    {
        public FlyweightB()
        {
            Symbol = "B";
            Width = 10;
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
}
