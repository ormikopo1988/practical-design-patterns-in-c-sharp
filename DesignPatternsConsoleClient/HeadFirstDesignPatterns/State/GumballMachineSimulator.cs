using HeadFirstDesignPatterns.State;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.State
{
    public class GumballMachineSimulator
    {
        public static void Start()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}