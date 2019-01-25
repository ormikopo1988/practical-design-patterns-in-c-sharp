using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Composite
{
    public class Menu : MenuComponent
    {
        private ArrayList menuComponents;
        private string name;
        private string description;

        private IEnumerator iterator = null;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.menuComponents = new ArrayList();
        }

        public override void Add(MenuComponent menuComponent)
        {
            this.menuComponents.Add(menuComponent);
        }

        public override IEnumerator CreateIterator()
        {
            if (this.iterator == null)
            {
                var componentIterator = this.menuComponents.GetEnumerator();

                this.iterator = new CompositeIterator(componentIterator);
            }

            return this.iterator;
        }

        public override MenuComponent GetChild(int i)
        {
            return this.menuComponents[i] as MenuComponent;
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Print()
        {
            Console.Write("\n" + this.GetName());
            Console.WriteLine(", " + this.GetDescription());
            Console.WriteLine("---------------------");

            IEnumerator iterator = this.menuComponents.GetEnumerator();

            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current as MenuComponent;

                menuComponent.Print();
            }
        }

        public override void Remove(MenuComponent menuComponent)
        {
            this.menuComponents.Remove(menuComponent);
        }
    }
}