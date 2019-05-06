using StateGumballMachine.States;

namespace StateGumballMachine.Entities
{
    public class GumballMachine
    {
        public State CurrentState { get; set; }

        public State SoldOutState { get; private set; }
        public State SoldState { get; private set; }
        public State HasCoinState { get; private set; }
        public State NoCoinState { get; private set; }
        public State WinnerState { get; private set; }

        public int Count { get; private set; }

        public GumballMachine(int count)
        {
            this.Count = count;

            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            HasCoinState = new HasCoinState(this);
            NoCoinState = new NoCoinState(this);
            WinnerState = new WinnerState(this);

            CurrentState = Count > 0 ? NoCoinState : SoldOutState;
        }

        public void InsertCoin()
        {
            CurrentState.InsertCoin();
        }

        public void EjectCoin()
        {
            CurrentState.EjectCoin();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            Count--;
        }

        public void Refill(int count)
        {
            Count += count;
            CurrentState = Count > 0 ? NoCoinState : SoldOutState;
        }
    }
}
