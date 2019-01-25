using System;

namespace HeadFirstDesignPatterns.Strategy
{
    public class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack...");
        }
    }
}