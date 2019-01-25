using System;

namespace HeadFirstDesignPatterns.State
{
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }
        public IState CurrentState { get; private set; }
        public int NumberGumballs { get; private set; }

        public GumballMachine(int numberGumballs)
        {
            this.SoldOutState = new SoldOutState(this);
            this.NoQuarterState = new NoQuarterState(this);
            this.HasQuarterState = new HasQuarterState(this);
            this.SoldState = new SoldState(this);
            this.WinnerState = new WinnerState(this);

            if (numberGumballs > 0)
            {
                this.CurrentState = this.NoQuarterState;
            }
            else
            {
                this.CurrentState = this.SoldOutState;
            }
            
            this.NumberGumballs = numberGumballs;
        }

        public void InsertQuarter()
        {
            this.CurrentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            this.CurrentState.EjectQuarter();
        }

        public void Refill(int count)
        {
            if (this.NumberGumballs == 0 && this.CurrentState is SoldOutState)
            {
                this.CurrentState = this.NoQuarterState;
            }

            this.NumberGumballs += count;
        }

        public void TurnCrank()
        {
            this.CurrentState.TurnCrank();
            this.CurrentState.Dispense();
        }

        internal void setState(IState newState)
        {
            this.CurrentState = newState;
        }

        internal void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if (this.NumberGumballs != 0)
            {
                this.NumberGumballs--;
            }
        }

        // other methods here like ToString() and Refill()
    }
}