using System;
using PizzaStoreFactoryMethod.Enums;
using PizzaStoreFactoryMethod.Products;

namespace PizzaStoreFactoryMethod.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYCheesePizza();
                case PizzaType.Olives:
                    return new NYOlivesPizza();
                case PizzaType.Sausage:
                    return new NYSausagePizza();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
