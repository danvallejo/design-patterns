using System.Collections.Generic;

namespace flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                switch (key)
                {
                    case "A":
                    {
                        flyweights[key] = new FlyweightA();
                        break;
                    }
                    case "B":
                    {
                        flyweights[key] = new FlyweightB();
                        break;
                    }
                }
            }

            return flyweights[key];
        }
    }
}
