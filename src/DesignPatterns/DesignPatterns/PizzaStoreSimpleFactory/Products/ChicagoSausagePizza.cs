namespace PizzaStoreSimpleFactory.Products
{
    public class ChicagoSausagePizza : ChicagoPizza
    {
        public ChicagoSausagePizza()
        {
            Name = "Chicago Style Sausage Pizza";
            sauce = "Chicago Sauce for sausage pizza";
            toppings.Add("Sausage");
        }
    }
}
