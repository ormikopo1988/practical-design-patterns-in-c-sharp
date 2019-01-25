using System.Collections;

namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class Flock : IQuackable
    {
        private ArrayList quackers = new ArrayList();
        
        public void Add(IQuackable quacker)
        {
            this.quackers.Add(quacker);
        }

        public void Quack()
        {
            // Iterator pattern at work as well!
            IEnumerator iterator = this.quackers.GetEnumerator();

            while(iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current as IQuackable;

                quacker.Quack();
            }
        }

        public void NotifyObservers()
        {
            // Each IQuackable does its own notification so Flock does not have to worry about it.
            // This happens when Flock delegates Quack() to each IQuackable inside the Flock e.g. Line 23
        }

        public void RegisterObserver(IObserver observer)
        {
            IEnumerator iterator = this.quackers.GetEnumerator();

            while (iterator.MoveNext())
            {
                IQuackable duck = iterator.Current as IQuackable;

                duck.RegisterObserver(observer);
            }
        }
    }
}