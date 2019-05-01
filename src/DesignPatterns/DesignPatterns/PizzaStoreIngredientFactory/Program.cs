using System;
using PizzaStoreIngredientFactory.Enums;
using PizzaStoreIngredientFactory.Stores;

namespace PizzaStoreIngredientFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore;
            pizzaStore = new NYPizzaStore();
            pizzaStore.OrderPizza(PizzaType.Pepperoni);

            Console.WriteLine("\n");

            pizzaStore = new ChicagoPizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheese);

            Console.ReadKey();
        }
    }
}
