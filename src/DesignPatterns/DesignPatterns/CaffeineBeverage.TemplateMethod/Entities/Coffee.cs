using System;

namespace CaffeineBeverageTemplateMethod.Entities
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk.");
        }

        protected override bool RequiresCondiments()
        {
            Console.Write("Would you like coffee with milk? (y/n): ");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Y;
        }
    }
}
