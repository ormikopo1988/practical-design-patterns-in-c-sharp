using System;

namespace HeadFirstDesignPatterns.State
{
    public class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            this.gumballMachine.releaseBall();

            if (this.gumballMachine.NumberGumballs > 0)
            {
                this.gumballMachine.setState(gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");

                this.gumballMachine.setState(gumballMachine.SoldOutState);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
    }
}