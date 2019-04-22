using System;
using System.Collections.Generic;
using DuckExample.Entities;

namespace DuckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>
            {
                new DecoyDuck(),
                new MallardDuck(),
                new RedheadDuck(),
                new WoodenDuck(),
                new RubberDuck()
            };

            foreach (var item in ducks)
            {
                item.Display();
                item.Swim();
                item.PerformQuacking();
                item.PerformFlying();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
