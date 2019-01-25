using System;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck.GetType().Name + " just quacked.");
        }
    }
}