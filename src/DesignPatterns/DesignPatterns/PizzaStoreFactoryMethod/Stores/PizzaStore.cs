using PizzaStoreFactoryMethod.Enums;
using PizzaStoreFactoryMethod.Products;

namespace PizzaStoreFactoryMethod.Stores
{
    public abstract class PizzaStore
    {
        public void OrderPizza(PizzaType type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}
