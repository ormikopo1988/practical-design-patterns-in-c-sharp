using System;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class DuckCall : IQuackable
    {
        private Observable observable;

        public DuckCall()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak!");

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