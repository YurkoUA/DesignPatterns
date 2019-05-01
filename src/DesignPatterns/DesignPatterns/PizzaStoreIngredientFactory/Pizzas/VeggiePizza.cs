using System;
using PizzaStoreIngredientFactory.CookBehavior;
using PizzaStoreIngredientFactory.IngredientFactory;

namespace PizzaStoreIngredientFactory.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory, IPizzaCookBehavior cookBehavior) : base(ingredientFactory, cookBehavior)
        {
        }

        public override void Prepare()
        {
            Pepperoni = ingredientFactory.CreatePepperoni();
            Dough = ingredientFactory.CreateDough();
            Veggies = ingredientFactory.CreateVeggies();

            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine(Pepperoni.GetType().ToString());
            Console.WriteLine(Dough.GetType().ToString());

            foreach (var item in Veggies)
            {
                Console.WriteLine(item.GetType().ToString());
            }
        }
    }
}
