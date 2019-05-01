namespace PizzaStoreFactoryMethod.Products
{
    public class ChicagoOlivesPizza : ChicagoPizza
    {
        public ChicagoOlivesPizza()
        {
            Name = "Chicago Style Olives Pizza";
            sauce = "Chicago Sauce for olives pizza";
            toppings.Add("Olives");
        }
    }
}
