using System;

namespace CaffeineBeverageTemplateMethod.Entities
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding a slice of lemon.");
        }

        protected override bool RequiresCondiments()
        {
            Console.Write("Would you like tea with lemon? (y/n): ");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Y;
        }
    }
}
