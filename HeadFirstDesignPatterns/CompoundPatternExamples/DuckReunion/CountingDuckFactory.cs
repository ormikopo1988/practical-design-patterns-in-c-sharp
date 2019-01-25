namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounterDecorator(new DuckCall());
        }

        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounterDecorator(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounterDecorator(new RedheadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounterDecorator(new RubberDuck());
        }
    }
}