using System;

namespace HeadFirstDesignPatterns.State
{
    public class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;
        private Random randomWinner;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            this.randomWinner = new Random(DateTime.Now.Millisecond);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");

            this.gumballMachine.setState(this.gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");

            int winner = this.randomWinner.Next(10);

            if ((winner == 0) && (this.gumballMachine.NumberGumballs > 1))
            {
                this.gumballMachine.setState(this.gumballMachine.WinnerState);
            }
            else
            {
                this.gumballMachine.setState(this.gumballMachine.SoldState);
            }
        }
    }
}