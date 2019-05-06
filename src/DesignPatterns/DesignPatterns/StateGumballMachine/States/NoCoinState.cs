using System;
using StateGumballMachine.Entities;

namespace StateGumballMachine.States
{
    public class NoCoinState : State
    {
        public NoCoinState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertCoin()
        {
            Console.WriteLine("You inserted a coin.");
            gumballMachine.CurrentState = gumballMachine.HasCoinState;
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You haven't inserted a coin.");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("There's no coin.");
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }
    }
}
