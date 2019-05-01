namespace PizzaStoreSimpleFactory.Products
{
    public class NYOlivesPizza : NYPizza
    {
        public NYOlivesPizza()
        {
            Name = "NY Style Olives Pizza";
            sauce = "NYC Sauce for olives pizza";
            toppings.Add("Olives");
        }
    }
}
