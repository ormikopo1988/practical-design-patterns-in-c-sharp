using HeadFirstDesignPatterns.Factory.AbstractFactory;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Factory.AbstractFactory
{
    public class PizzaUsingAbstractFactorySimulator
    {
        public static void Start()
        {
            // New York Cheese Pizza
            PizzaStore nyPizzaStore = new NYPizzaStore();

            nyPizzaStore.OrderPizza("cheese");

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            chicagoPizzaStore.OrderPizza("cheese");
        }
    }
}