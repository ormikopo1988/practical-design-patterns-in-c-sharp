using HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion;
using System;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class DuckSimulator
    {
        public static void Start()
        {
            Console.WriteLine("\n----- Duck Simulator -----");

            AbstractDuckFactory abstractDuckFactory = new CountingDuckFactory();
            AbstractGooseFactory abstractGooseFactory = new GooseDuckFactory();

            generateDucksAndRunSimulation(abstractDuckFactory, abstractGooseFactory);
        }

        private static void generateDucksAndRunSimulation(AbstractDuckFactory abstractDuckFactory, AbstractGooseFactory abstractGooseFactory)
        {
            IQuackable redheadDuck = abstractDuckFactory.CreateRedheadDuck();
            IQuackable duckCall = abstractDuckFactory.CreateDuckCall();
            IQuackable rubberDuck = abstractDuckFactory.CreateRubberDuck();

            IQuackable gooseDuck = abstractGooseFactory.CreateGoose();

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            // Create a little family of mallards here
            IQuackable mallardDuck1 = abstractDuckFactory.CreateMallardDuck();
            IQuackable mallardDuck2 = abstractDuckFactory.CreateMallardDuck();
            IQuackable mallardDuck3 = abstractDuckFactory.CreateMallardDuck();
            IQuackable mallardDuck4 = abstractDuckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardDuck1);
            flockOfMallards.Add(mallardDuck2);
            flockOfMallards.Add(mallardDuck3);
            flockOfMallards.Add(mallardDuck4);

            // Also add the flock of mallards to the flock of ducks - They are ducks in the end too!
            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation with observer");
            IObserver quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked " + QuackCounterDecorator.GetNumberOfQuacks() + " times");
        }

        private static void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}