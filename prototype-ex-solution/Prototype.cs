﻿namespace prototype_ex_solution
{
    public interface IPrototype<T>
    {
        T Clone();
    }

    public class Apple : IPrototype<Apple>
    {
        public Apple Clone()
        {
            //etc
            return null;
        }
    }

    public class Concrete : IPrototype<Concrete>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Concrete Clone()
        {
            return MemberwiseClone() as Concrete;
        }
    }

}