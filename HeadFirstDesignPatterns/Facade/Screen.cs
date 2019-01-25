using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen up.");
        }

        public void Down()
        {
            Console.WriteLine("Screen down.");
        }
    }
}