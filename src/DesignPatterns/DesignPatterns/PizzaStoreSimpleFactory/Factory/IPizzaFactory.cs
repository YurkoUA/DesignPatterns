using PizzaStoreSimpleFactory.Enums;
using PizzaStoreSimpleFactory.Products;

namespace PizzaStoreSimpleFactory.Factory
{
    public interface IPizzaFactory
    {
        Pizza CreatePizza(PizzaType type);
    }
}
