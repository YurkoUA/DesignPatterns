using System;
using PizzaStoreFactoryMethod.Enums;
using PizzaStoreFactoryMethod.Products;

namespace PizzaStoreFactoryMethod.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
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
