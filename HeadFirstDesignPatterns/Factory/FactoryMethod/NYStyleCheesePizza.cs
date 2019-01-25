using System;

namespace HeadFirstDesignPatterns.Factory.FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() 
            : base("Chicago Style Deep Dish Cheese Pizza", "Extra Thick Crust Dough", "Plum Tomato Sauce")
        {
            this.Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}