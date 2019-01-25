using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Iterator
{
    public class Waitress
    {
        private ArrayList menus;

        public Waitress(ArrayList menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach(IMenu<MenuItem> menu in this.menus)
            {
                this.PrintMenu(menu.CreateIterator());
            }
        }

        private void PrintMenu(Iterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();

                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }

            Console.WriteLine();
        }

        // other methods here
    }
}