using System.Collections.Generic;

namespace flyweight_ex_solution
{
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
        private static object sync = new object();
        private static FlyweightFactory factory;

        public static FlyweightFactory Instance
        {
            get
            {
                if (factory == null)
                {
                    lock (sync)
                    {
                        if (factory == null)
                        {
                            factory = new FlyweightFactory();
                        }
                    }
                }

                return factory;
            }
        }

        public IFlyweight GetFlyweight(string key)
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

    public static class FlyweightFactoryStatic
    {
        private static Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public static IFlyweight GetFlyweight(string key)
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
