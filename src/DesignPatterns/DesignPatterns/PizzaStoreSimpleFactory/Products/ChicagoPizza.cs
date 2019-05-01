using System;

namespace PizzaStoreSimpleFactory.Products
{
    public abstract class ChicagoPizza : Pizza
    {
        public ChicagoPizza()
        {
            dough = "“Extra Thick Crust Dough";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into square slices.");
        }

        public override void Box()
        {
            Console.WriteLine("Packing in a Chicago brand package.");
        }
    }
}
