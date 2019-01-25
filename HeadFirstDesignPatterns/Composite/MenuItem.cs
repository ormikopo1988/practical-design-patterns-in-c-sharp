using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Composite
{
    public class MenuItem : MenuComponent
    {
        private string name;
        private string description;
        private bool isVegetarian;
        private double price;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.isVegetarian = isVegetarian;
            this.price = price;
        }

        public override IEnumerator CreateIterator()
        {
            return new NullIterator();
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override double GetPrice()
        {
            return this.price;
        }

        public override bool IsVegetarian()
        {
            return this.isVegetarian;
        }

        public override void Print()
        {
            Console.Write(" " + this.GetName());


            if (this.IsVegetarian())
            {
                Console.Write("(v)");
            }

            Console.WriteLine(", " + this.GetPrice());
            Console.WriteLine(" -- " + this.GetDescription());
        }
    }
}