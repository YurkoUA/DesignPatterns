using System;

namespace Starbuzz.Infrastructure
{
    public abstract class Component
    {
        public string Description { get; set; }
        public abstract decimal CalculateCost();

        public void Print()
        {
            Console.WriteLine($"{Description}: {CalculateCost()}");
        }
    }
}
