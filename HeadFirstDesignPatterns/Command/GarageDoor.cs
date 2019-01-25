using System;

namespace HeadFirstDesignPatterns.Command
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door opened.");
        }

        public void Down()
        {
            Console.WriteLine("Garage door closed.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door stop.");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light on.");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light off.");
        }
    }
}