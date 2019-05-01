using System;

namespace PizzaStoreFactoryMethod.Products
{
    public abstract class NYPizza : Pizza
    {
        public NYPizza()
        {
            dough = "Thin Crust Dough";
        }

        public override void Box()
        {
            Console.WriteLine("Packing in a NY brand package.");
        }
    }
}
