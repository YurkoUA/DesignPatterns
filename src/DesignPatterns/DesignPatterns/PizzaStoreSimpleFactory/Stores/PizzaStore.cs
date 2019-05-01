using PizzaStoreSimpleFactory.Enums;
using PizzaStoreSimpleFactory.Factory;
using PizzaStoreSimpleFactory.Products;

namespace PizzaStoreSimpleFactory.Stores
{
    public class PizzaStore
    {
        private IPizzaFactory pizzaFactory;

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public void OrderPizza(PizzaType type)
        {
            Pizza pizza = pizzaFactory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
