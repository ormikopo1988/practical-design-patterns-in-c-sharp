using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Composite
{
    public class Waitress
    {
        private MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            this.allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator iterator = this.allMenus.CreateIterator();

            Console.WriteLine("\nVEGETARIAN MENU\n---------------");

            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current as MenuComponent;

                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (InvalidOperationException) {}
            }
        }
    }
}