using System.Collections.Generic;
using PizzaStoreIngredientFactory.Products;

namespace PizzaStoreIngredientFactory.IngredientFactory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sause CreateSause();
        Cheese CreateCheese();
        IEnumerable<Veggie> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}
