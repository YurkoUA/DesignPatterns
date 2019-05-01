namespace PizzaStoreSimpleFactory.Products
{
    public class ChicagoCheesePizza : ChicagoPizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Style Cheese Pizza";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
