using System.Collections.Generic;
using PizzaStoreIngredientFactory.Products;

namespace PizzaStoreIngredientFactory.IngredientFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();

        public Clams CreateClams() => new FreshClams();

        public Dough CreateDough() => new ThinCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sause CreateSause() => new MarinaraSauce();

        public IEnumerable<Veggie> CreateVeggies()
        {
            return new Veggie[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
