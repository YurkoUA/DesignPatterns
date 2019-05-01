namespace PizzaStoreFactoryMethod.Products
{
    public class NYSausagePizza : NYPizza
    {
        public NYSausagePizza()
        {
            Name = "NY Style Sausage Pizza";
            sauce = "NYC Sauce for sausage pizza";
            toppings.Add("Sausage");
        }
    }
}
