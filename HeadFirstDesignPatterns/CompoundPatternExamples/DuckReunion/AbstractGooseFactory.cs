namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public abstract class AbstractGooseFactory
    {
        public abstract IQuackable CreateGoose();
    }
}