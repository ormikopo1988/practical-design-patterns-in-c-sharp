using System;

namespace HeadFirstDesignPatterns.Command
{
    public class CeilingFan
    {
        public int Speed { get; private set; }

        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string location;
        
        public CeilingFan(String location)
        {
            this.location = location;
            this.Speed = OFF;
        }

        public void On()
        {
            Console.WriteLine($"Ceiling fan in {this.location} on.");
        }

        public void Off()
        {
            Console.WriteLine($"Ceiling fan in {this.location} off.");
        }

        public void High()
        {
            this.Speed = HIGH;
            Console.WriteLine($"Setting ceiling fan in {this.location} to high.");
        }
        public void Medium()
        {
            this.Speed = MEDIUM;
            Console.WriteLine($"Setting ceiling fan in {this.location} to medium.");
        }

        public void Low()
        {
            this.Speed = LOW;
            Console.WriteLine($"Setting ceiling fan in {this.location} to low.");
        }
    }
}