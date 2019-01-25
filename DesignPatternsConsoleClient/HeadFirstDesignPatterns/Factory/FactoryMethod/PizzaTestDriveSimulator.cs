using HeadFirstDesignPatterns.Factory.FactoryMethod;
using System;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Factory.FactoryMethod
{
    public class PizzaTestDriveSimulator
    {
        public static void Start()
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");

            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("cheese");

            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");
        }
    }
}