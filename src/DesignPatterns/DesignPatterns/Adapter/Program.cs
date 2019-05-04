using System;
using Adapter.Entities;
using Adapter.Infrastructure;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine();

            TestDuck(duck);

            Console.WriteLine();

            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
