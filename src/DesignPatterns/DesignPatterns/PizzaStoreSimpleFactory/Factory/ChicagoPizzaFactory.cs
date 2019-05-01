using System;
using PizzaStoreSimpleFactory.Enums;
using PizzaStoreSimpleFactory.Products;

namespace PizzaStoreSimpleFactory.Factory
{
    public class ChicagoPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoCheesePizza();
                case PizzaType.Olives:
                    return new ChicagoOlivesPizza();
                case PizzaType.Sausage:
                    return new ChicagoSausagePizza();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
