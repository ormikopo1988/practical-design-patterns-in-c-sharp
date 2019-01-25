using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("TheaterLights on.");
        }

        public void Off()
        {
            Console.WriteLine("TheaterLights off.");
        }

        public void Dim(int percent)
        {
            Console.WriteLine($"Dim TheaterLights to {percent}%.");
        }
    }
}