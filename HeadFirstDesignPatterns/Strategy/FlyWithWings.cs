using System;

namespace HeadFirstDesignPatterns.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}