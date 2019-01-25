namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;
        private Observable observable;
        
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            this.goose.Honk();
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