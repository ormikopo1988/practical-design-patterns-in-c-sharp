using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Behavioral.Observer
{
    public abstract class Subject
    {
        private List<IObserver> observers;

        public Subject()
        {
            this.observers = new List<IObserver>();
        }

        public virtual void Attach(IObserver theAttachedObserver)
        {
            this.observers.Add(theAttachedObserver);
        }

        public virtual void Detach(IObserver theDetachedObserver)
        {
            this.observers.Remove(theDetachedObserver);
        }

        public virtual void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}