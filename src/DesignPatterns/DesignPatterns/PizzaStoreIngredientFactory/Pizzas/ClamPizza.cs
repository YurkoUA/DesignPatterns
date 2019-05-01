using System;
using PizzaStoreIngredientFactory.CookBehavior;
using PizzaStoreIngredientFactory.IngredientFactory;

namespace PizzaStoreIngredientFactory.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory ingredientFactory, IPizzaCookBehavior cookBehavior) : base(ingredientFactory, cookBehavior)
        {
        }

        public override void Prepare()
        {
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSause();
            Cheese = ingredientFactory.CreateCheese();
            Clams = ingredientFactory.CreateClams();

            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine(Dough.GetType().ToString());
            Console.WriteLine(Sauce.GetType().ToString());
            Console.WriteLine(Cheese.GetType().ToString());
            Console.WriteLine(Clams.GetType().ToString());
        }
    }
}
