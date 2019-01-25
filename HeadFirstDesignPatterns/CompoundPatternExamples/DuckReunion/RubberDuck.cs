using System;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class RubberDuck : IQuackable
    {
        private Observable observable;

        public RubberDuck()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeak!");

            this.NotifyObservers();
        }

        public void NotifyObservers()
        {
            this.observable.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observable.RegisterObserver(observer);
        }
    }
}