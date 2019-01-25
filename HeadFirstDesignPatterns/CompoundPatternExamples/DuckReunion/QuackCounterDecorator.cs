namespace HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion
{
    public class QuackCounterDecorator : IQuackable
    {
        private IQuackable duck;
        private static int numberOfQuacks;
        
        public QuackCounterDecorator(IQuackable duck)
        {
            this.duck = duck;
        }

        public static int GetNumberOfQuacks()
        {
            return numberOfQuacks;
        }

        public void Quack()
        {
            this.duck.Quack();
            numberOfQuacks++;
        }

        public void NotifyObservers()
        {
            this.duck.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.duck.RegisterObserver(observer);
        }
    }
}