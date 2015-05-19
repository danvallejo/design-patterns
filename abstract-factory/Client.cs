using System.Collections.Generic;

namespace abstract_factory
{
    public class Client
    {
        private readonly List<Product> shoppingCart;

        public Client()
        {
            shoppingCart = new List<Product>();
        }

        public void AddToCart()
        {
            shoppingCart.Add(AbstractFactory.CreateFactoryApple().Create());
            shoppingCart.Add(AbstractFactory.CreateFactoryBerry().Create());
        }
    }
}
