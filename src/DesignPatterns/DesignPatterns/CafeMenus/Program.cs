using System;
using CafeMenus.Entities;
using CafeMenus.Menus;

namespace CafeMenus
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu { Name = "ALL", Description = "All Menus" };

            var coffeeMenu = new Menu { Name = "Coffee", Description = "Coffee Menu" };

            var coffeeDesertMenu = new Menu { Name = "Deserts", Description = "Coffee Deserts Menu" };
            coffeeMenu.Add(coffeeDesertMenu);
            menu.Add(coffeeMenu);

            coffeeMenu.Add(new MenuItem { Name = "Dark Coffee", Price = 10 });
            coffeeMenu.Add(new MenuItem { Name = "Espresso", Price = 12 });
            coffeeMenu.Add(new MenuItem { Name = "Latte", Price = 16 });

            coffeeDesertMenu.Add(new MenuItem { Name = "Milk Ice-Cream", Price = 20 });
            coffeeDesertMenu.Add(new MenuItem { Name = "Chocolate Ice-Cream", Price = 22 });

            var dinnerMenu = new Menu { Name = "Dinner", Description = "Dinner Menu" };
            menu.Add(dinnerMenu);

            dinnerMenu.Add(new MenuItem { Name = "Borsch", Price = 30 });
            dinnerMenu.Add(new MenuItem { Name = "Green Borsch", Price = 35, IsVegeterian = true });
            dinnerMenu.Add(new MenuItem { Name = "Soup", Price = 29 });

            var waitress = new Waitress(menu);

            waitress.Print();

            Console.WriteLine("Vegeterian Products:");

            waitress.PrintVegeterianMenu();

            Console.ReadKey();
        }
    }
}
