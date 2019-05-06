using StateGumballMachine.Entities;

namespace StateGumballMachine.States
{
    public abstract class State
    {
        protected readonly GumballMachine gumballMachine;

        public State(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public abstract void InsertCoin();
        public abstract void EjectCoin();
        public abstract void TurnCrank();
        public abstract void Dispense();
    }
}
