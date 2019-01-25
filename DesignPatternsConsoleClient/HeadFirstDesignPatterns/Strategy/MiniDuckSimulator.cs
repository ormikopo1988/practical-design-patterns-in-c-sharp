using HeadFirstDesignPatterns.Strategy;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Strategy
{
    public class MiniDuckSimulator
    {
        public static void Start()
        {
            Duck mallard = new MallardDuck(new FlyWithWings(), new SimpleQuack());

            mallard.PerformQuack();
            mallard.PerformFly();
        }
    }
}