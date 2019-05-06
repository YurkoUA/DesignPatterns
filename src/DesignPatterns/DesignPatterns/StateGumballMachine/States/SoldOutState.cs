using System;
using StateGumballMachine.Entities;

namespace StateGumballMachine.States
{
    public class SoldOutState : State
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertCoin()
        {
            Console.WriteLine("You can’t insert a coin, the machine is sold out.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You can’t eject, you haven’t inserted a coin yet.");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("“You turned, but there are no gumballs.");
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }
    }
}
