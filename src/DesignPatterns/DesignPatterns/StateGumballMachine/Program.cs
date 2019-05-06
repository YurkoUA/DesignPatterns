using System;
using StateGumballMachine.Entities;

namespace StateGumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(100);

            machine.InsertCoin();
            machine.TurnCrank();

            Console.ReadKey();
        }
    }
}
