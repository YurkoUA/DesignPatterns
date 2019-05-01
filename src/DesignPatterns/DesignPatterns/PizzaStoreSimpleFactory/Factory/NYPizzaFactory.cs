using System;
using PizzaStoreSimpleFactory.Enums;
using PizzaStoreSimpleFactory.Products;

namespace PizzaStoreSimpleFactory.Factory
{
    public class NYPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza(PizzaType type)
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
