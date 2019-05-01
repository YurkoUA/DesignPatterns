using System.Collections.Generic;
using PizzaStoreIngredientFactory.Products;

namespace PizzaStoreIngredientFactory.IngredientFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new MozzarellaCheese();

        public Clams CreateClams() => new FrozenClams();

        public Dough CreateDough() => new ThickCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sause CreateSause() => new PlumTomatoSauce();

        public IEnumerable<Veggie> CreateVeggies()
        {
            return new Veggie[] { new Spinach(), new BlackOlives(), new EggPlant() };
        }
    }
}
