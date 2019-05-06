using System;
using StateGumballMachine.Entities;

namespace StateGumballMachine.States
{
    public class HasCoinState : State
    {
        private readonly Random randomWinner = new Random();

        public HasCoinState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertCoin()
        {
            Console.WriteLine("You can't insert more coins.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("The coin is returned back.");
            gumballMachine.CurrentState = gumballMachine.NoCoinState;
        }

        public override void TurnCrank()
        {
            Console.WriteLine("The crank is turned.");

            var number = randomWinner.Next(0, 10);
            var isWinner = number == 0;

            if (isWinner && gumballMachine.Count > 1)
            {
                gumballMachine.CurrentState = gumballMachine.WinnerState;
            }
            else
            {
                gumballMachine.CurrentState = gumballMachine.SoldState;
            }
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
