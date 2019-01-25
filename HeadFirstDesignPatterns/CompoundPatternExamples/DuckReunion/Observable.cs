using System.Collections;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class Observable : IQuackObservable
    {
        private ArrayList observers = new ArrayList();
        private IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyObservers()
        {
            IEnumerator iterator = this.observers.GetEnumerator();

            while (iterator.MoveNext())
            {
                IObserver observer = iterator.Current as IObserver;

                observer.Update(duck);
            }
        }
    }
}