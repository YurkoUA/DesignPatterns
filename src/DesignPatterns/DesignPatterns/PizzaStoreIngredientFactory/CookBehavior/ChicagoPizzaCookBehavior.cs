using System;

namespace PizzaStoreIngredientFactory.CookBehavior
{
    public class ChicagoPizzaCookBehavior : IPizzaCookBehavior
    {
        public void Bake()
        {
            Console.WriteLine("Baking pizza for 45 minutes.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza into square slices.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza in Chicago style package.");
        }
    }
}
