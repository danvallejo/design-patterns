using System.Collections.Generic;

namespace factory_solution
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
            shoppingCart.Add(ProductFactory.Create(ProductType.Apple));
            shoppingCart.Add(ProductFactory.Create(ProductType.Berry));
        }
    }
}
