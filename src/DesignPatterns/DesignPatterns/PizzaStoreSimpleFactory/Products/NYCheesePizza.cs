namespace PizzaStoreSimpleFactory.Products
{
    public class NYCheesePizza : NYPizza
    {
        public NYCheesePizza()
        {
            Name = "NY Style Cheese Pizza";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
