using System;

namespace PizzaStoreIngredientFactory.CookBehavior
{
    public class NYPizzaCookBehavior : IPizzaCookBehavior
    {
        public void Bake()
        {
            Console.WriteLine("Baking pizza for 30 minutes.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza in NY style package.");
        }
    }
}
