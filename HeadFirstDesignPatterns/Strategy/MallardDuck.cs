using System;

namespace HeadFirstDesignPatterns.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard duck!");
        }
    }
}