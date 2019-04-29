using System;
using System.Collections.Generic;
using Starbuzz.Entities;
using Starbuzz.Infrastructure;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your past orders:\n");

            var orders = new List<Component>
            {
                new Lemon(new Lemon(new BlackTea())),
                new Milk(new Milk(new DarkCoffee())),
                new Mocha(new DarkCoffee()),
                new Espresso(),
                new Milk(new Espresso()),
                new Milk(new Mocha(new Espresso()))
            };

            orders.ForEach(o => o.Print());

            Console.ReadKey();
        }
    }
}
