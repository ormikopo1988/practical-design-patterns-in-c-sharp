using System;
using HeadFirstDesignPatterns.Decorator;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Decorator
{
    public class StarbuzzCoffeeSimulator
    {
        public static void Start()
        {
            IBeverage beverage = new Espresso(BeverageSize.TALL);

            Console.WriteLine($"{beverage.Description} ${beverage.Cost()}");

            IBeverage beverage2 = new Whip(new Mocha(new Mocha(new DarkRoast(BeverageSize.GRANDE))));

            Console.WriteLine($"{beverage2.Description} ${beverage2.Cost()}");

            IBeverage beverage4 = new HouseBlend(BeverageSize.VENTI);
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);

            Console.WriteLine($"{beverage4.Description} ${beverage4.Cost()}");
        }
    }
}