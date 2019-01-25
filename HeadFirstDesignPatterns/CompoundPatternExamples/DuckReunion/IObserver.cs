namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}