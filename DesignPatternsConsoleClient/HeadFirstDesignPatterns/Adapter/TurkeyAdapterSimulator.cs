using HeadFirstDesignPatterns.Adapter;
using System;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Adapter
{
    public class TurkeyAdapterSimulator
    {
        public static void Start()
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");

            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");

            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");

            testDuck(turkeyAdapter);
        }

        private static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}