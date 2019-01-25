using System;

namespace HeadFirstDesignPatterns.Command
{
    public class Hottub
    {
        public void On()
        {
            Console.WriteLine($"Hottub on.");
        }

        public void Off()
        {
            Console.WriteLine($"Hottub off.");
        }
    }
}