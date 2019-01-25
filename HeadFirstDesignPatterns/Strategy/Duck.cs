using System;

namespace HeadFirstDesignPatterns.Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            this.flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this.quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}