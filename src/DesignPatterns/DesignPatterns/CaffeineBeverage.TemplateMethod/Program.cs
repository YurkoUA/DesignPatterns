using System;
using CaffeineBeverageTemplateMethod.Entities;

namespace CaffeineBeverageTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee:\n");

            var coffee = new Coffee();
            coffee.Cook();

            Console.WriteLine("Tea:\n");

            var tea = new Tea();
            tea.Cook();

            Console.ReadKey();
        }
    }
}
