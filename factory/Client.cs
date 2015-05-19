using System.Collections.Generic;

namespace factory
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
            shoppingCart.Add(new AppleFactory().Create());
            shoppingCart.Add(new BerryFactory().Create());
        }
    }
}
