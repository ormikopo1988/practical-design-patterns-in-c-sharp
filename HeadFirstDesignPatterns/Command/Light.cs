using System;

namespace HeadFirstDesignPatterns.Command
{
    public class Light
    {
        private string lightName;

        public Light(string lightName)
        {
            this.lightName = lightName;
        }

        public void On()
        {
            Console.WriteLine($"{this.lightName} light on.");
        }

        public void Off()
        {
            Console.WriteLine($"{this.lightName} light off.");
        }
    }
}