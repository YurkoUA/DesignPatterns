using System;
using System.Collections.Generic;
using PizzaStoreIngredientFactory.CookBehavior;
using PizzaStoreIngredientFactory.IngredientFactory;
using PizzaStoreIngredientFactory.Products;

namespace PizzaStoreIngredientFactory.Pizzas
{
    public abstract class Pizza
    {
        protected IPizzaIngredientFactory ingredientFactory;
        protected IPizzaCookBehavior cookBehavior;

        public Pizza(IPizzaIngredientFactory ingredientFactory, IPizzaCookBehavior cookBehavior)
        {
            this.ingredientFactory = ingredientFactory;
            this.cookBehavior = cookBehavior;
        }

        public string Name { get; set; }

        public Dough Dough { get; protected set; }
        public Sause Sauce { get; protected set; }
        public Cheese Cheese { get; protected set; }
        public Clams Clams { get; protected set; }
        public Pepperoni Pepperoni { get; protected set; }
        protected IEnumerable<Veggie> Veggies { get; set; } = new List<Veggie>();

        public abstract void Prepare();

        public void Bake()
        {
            cookBehavior.Bake();
        }

        public void Cut()
        {
            cookBehavior.Cut();
        }

        public void Box()
        {
            cookBehavior.Box();
        }
    }
}
