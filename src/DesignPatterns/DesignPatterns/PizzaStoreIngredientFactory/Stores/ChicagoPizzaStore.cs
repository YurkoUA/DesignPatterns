using System;
using PizzaStoreIngredientFactory.CookBehavior;
using PizzaStoreIngredientFactory.Enums;
using PizzaStoreIngredientFactory.IngredientFactory;
using PizzaStoreIngredientFactory.Pizzas;

namespace PizzaStoreIngredientFactory.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            var factory = new ChicagoPizzaIngredientFactory();
            var behavior = new ChicagoPizzaCookBehavior();

            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza(factory, behavior) { Name = "Chicago Cheese Pizza" };
                case PizzaType.Clam:
                    return new ClamPizza(factory, behavior) { Name = "Chicago Clam Pizza" };
                case PizzaType.Pepperoni:
                    return new PepperoniPizza(factory, behavior) { Name = "Chicago Pepperoni Pizza" };
                case PizzaType.Veggie:
                    return new VeggiePizza(factory, behavior) { Name = "Chicago Veggie Pizza" };
                default:
                    throw new ArgumentException();
            }
        }
    }
}
