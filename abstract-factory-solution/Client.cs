using System.Collections.Generic;

namespace abstract_factory_solution
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
            shoppingCart.Add(AbstractFactory.CreateFactory(ProductType.Apple).Create());
            shoppingCart.Add(AbstractFactory.CreateFactory(ProductType.Berry).Create());
        }
    }
}
