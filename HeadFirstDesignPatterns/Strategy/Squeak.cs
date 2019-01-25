using System;

namespace HeadFirstDesignPatterns.Strategy
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak...");
        }
    }
}