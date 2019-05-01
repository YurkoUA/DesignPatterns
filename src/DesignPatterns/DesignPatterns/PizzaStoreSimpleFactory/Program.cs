using System;
using PizzaStoreSimpleFactory.Enums;
using PizzaStoreSimpleFactory.Factory;
using PizzaStoreSimpleFactory.Stores;

namespace PizzaStoreSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory pizzaFactory = new NYPizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(pizzaFactory);
            pizzaStore.OrderPizza(PizzaType.Sausage);

            Console.WriteLine("\n");

            pizzaFactory = new ChicagoPizzaFactory();
            pizzaStore = new PizzaStore(pizzaFactory);
            pizzaStore.OrderPizza(PizzaType.Olives);

            Console.ReadKey();
        }
    }
}
