using PizzaStoreIngredientFactory.Enums;
using PizzaStoreIngredientFactory.Pizzas;

namespace PizzaStoreIngredientFactory.Stores
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
