using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("PopcornPopper on.");
        }

        public void Off()
        {
            Console.WriteLine("PopcornPopper off.");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper start popping.");
        }
    }
}