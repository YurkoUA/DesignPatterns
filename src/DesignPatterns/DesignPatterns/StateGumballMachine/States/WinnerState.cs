using System;
using StateGumballMachine.Entities;

namespace StateGumballMachine.States
{
    public class WinnerState : State
    {
        public WinnerState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();

            if (gumballMachine.Count > 0)
            {
                gumballMachine.CurrentState = gumballMachine.NoCoinState;
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU’RE A WINNER! You got two gumballs for your coin.");

                if (gumballMachine.Count > 0)
                {
                    gumballMachine.CurrentState = gumballMachine.NoCoinState;
                }
                else
                {
                    gumballMachine.CurrentState = gumballMachine.SoldOutState;
                    Console.WriteLine("Oops, out of gumballs!");
                }
            }
            else
            {
                gumballMachine.CurrentState = gumballMachine.SoldOutState;
                Console.WriteLine("Oops, out of gumballs!");
            }
        }
    }
}
