using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Factory.FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; private set; }
        public string Dough { get; private set; }
        public string Sauce { get; private set; }
        public ArrayList Toppings { get; private set; }

        public Pizza(string name, string dough, string sauce)
        {
            this.Name = name;
            this.Dough = dough;
            this.Sauce = sauce;
            this.Toppings = new ArrayList();
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + this.Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            for (int i = 0; i < this.Toppings.Count; i++)
            {
                Console.WriteLine(" " + this.Toppings[i]);
            }
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices...");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees...");
        }
    }
}