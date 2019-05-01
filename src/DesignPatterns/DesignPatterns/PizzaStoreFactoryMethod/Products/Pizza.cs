using System;
using System.Collections.Generic;

namespace PizzaStoreFactoryMethod.Products
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }

        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Console.WriteLine($"Tossing dough: {dough}");
            Console.WriteLine($"Adding sauce: {sauce}");
            Console.WriteLine($"Adding toppings:");

            toppings.ForEach(t => Console.WriteLine(t));
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking for 45 minutes.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting into diagonal slices.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Packing in a brand box.");
        }
    }
}
