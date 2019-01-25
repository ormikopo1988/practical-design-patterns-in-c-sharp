using System;

namespace HeadFirstDesignPatterns.Adapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}