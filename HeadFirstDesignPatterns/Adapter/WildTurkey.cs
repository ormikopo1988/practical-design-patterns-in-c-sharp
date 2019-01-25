using System;

namespace HeadFirstDesignPatterns.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying a short distance.");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }
    }
}