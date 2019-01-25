using HeadFirstDesignPatterns.TemplateMethod;
using System;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.TemplateMethod
{
    public class CaffeineBeverageMakerSimulator
    {
        public static void Start()
        {
            Console.WriteLine("Start making tea...");

            CaffeineBeverage myTea = new Tea();
            myTea.PrepareRecipe();

            Console.WriteLine("Start making coffee...");

            CaffeineBeverage myCoffee = new Coffee();
            myCoffee.PrepareRecipe();
        }
    }
}