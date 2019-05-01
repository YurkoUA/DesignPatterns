using System;
using PizzaStoreIngredientFactory.CookBehavior;
using PizzaStoreIngredientFactory.Enums;
using PizzaStoreIngredientFactory.IngredientFactory;
using PizzaStoreIngredientFactory.Pizzas;

namespace PizzaStoreIngredientFactory.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            var factory = new NYPizzaIngredientFactory();
            var behavior = new NYPizzaCookBehavior();

            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza(factory, behavior) { Name = "NY Cheese Pizza" };
                case PizzaType.Clam:
                    return new ClamPizza(factory, behavior) { Name = "NY Clam Pizza" };
                case PizzaType.Pepperoni:
                    return new PepperoniPizza(factory, behavior) { Name = "NY Pepperoni Pizza" };
                case PizzaType.Veggie:
                    return new VeggiePizza(factory, behavior) { Name = "NY Veggie Pizza" };
                default:
                    throw new ArgumentException();
            }
        }
    }
}
