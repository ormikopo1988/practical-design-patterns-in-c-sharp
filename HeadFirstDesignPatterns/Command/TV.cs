using System;

namespace HeadFirstDesignPatterns.Command
{
    public class TV
    {
        private string location;

        public TV(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"TV in {this.location} on.");
        }

        public void Off()
        {
            Console.WriteLine($"TV in {this.location} off.");
        }
    }
}