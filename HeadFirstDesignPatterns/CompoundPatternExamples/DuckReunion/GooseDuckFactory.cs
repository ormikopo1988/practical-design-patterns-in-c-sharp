namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class GooseDuckFactory : AbstractGooseFactory
    {
        public override IQuackable CreateGoose()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
