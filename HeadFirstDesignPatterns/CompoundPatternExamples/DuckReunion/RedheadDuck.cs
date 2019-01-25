using System;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class RedheadDuck : IQuackable
    {
        private Observable observable;

        public RedheadDuck()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");

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