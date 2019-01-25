using System;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class MallardDuck : IQuackable
    {
        private Observable observable;

        public MallardDuck()
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