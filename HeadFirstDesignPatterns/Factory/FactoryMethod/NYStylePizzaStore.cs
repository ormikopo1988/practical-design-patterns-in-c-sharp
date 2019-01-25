﻿namespace HeadFirstDesignPatterns.Factory.FactoryMethod
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}