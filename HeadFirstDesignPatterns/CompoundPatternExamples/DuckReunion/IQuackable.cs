namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}