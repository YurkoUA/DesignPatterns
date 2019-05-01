using System;
using PizzaStoreFactoryMethod.Enums;
using PizzaStoreFactoryMethod.Stores;

namespace PizzaStoreFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NYPizzaStore();
            store.OrderPizza(PizzaType.Cheese);

            Console.WriteLine("\n");

            store = new ChicagoPizzaStore();
            store.OrderPizza(PizzaType.Sausage);

            Console.ReadKey();
        }
    }
}
