namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}