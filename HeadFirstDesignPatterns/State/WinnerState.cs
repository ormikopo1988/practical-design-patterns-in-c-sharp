using System;

namespace HeadFirstDesignPatterns.State
{
    public class WinnerState : IState
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU’RE A WINNER! You get two gumballs for your quarter!!!");

            this.gumballMachine.releaseBall();

            if (this.gumballMachine.NumberGumballs == 0)
            {
                Console.WriteLine("Oops, out of gumballs!");

                this.gumballMachine.setState(this.gumballMachine.SoldOutState);
            }
            else
            {
                this.gumballMachine.releaseBall();

                if (this.gumballMachine.NumberGumballs > 0)
                {
                    this.gumballMachine.setState(this.gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");

                    this.gumballMachine.setState(this.gumballMachine.SoldOutState);
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball and another one for free!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball, but this time will cause you won the Gumball price!");
        }
    }
}