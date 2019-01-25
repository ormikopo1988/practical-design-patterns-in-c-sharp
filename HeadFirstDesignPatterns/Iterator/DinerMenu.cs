using System;

namespace HeadFirstDesignPatterns.Iterator
{
    public class DinerMenu : IMenu<MenuItem>
    {
        private const int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            this.menuItems = new MenuItem[MAX_ITEMS];

            this.AddItem(
                "Vegetarian BLT",
                "(Fakin’) Bacon with lettuce & tomato on whole wheat", 
                true, 
                2.99
            );

            this.AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat", 
                false, 
                2.99
            );

            this.AddItem(
                "Soup of the day",
                "Soup of the day, with a side of potato salad", 
                false, 
                3.29
            );

            this.AddItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 
                3.05
            );
        
            // a couple of other Diner Menu items added here
        }

        public void AddItem(String name, String description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can’t add item to menu");
            }
            else
            {
                this.menuItems[numberOfItems] = menuItem;

                numberOfItems++;
            }
        }

        public Iterator<MenuItem> CreateIterator()
        {
            return new ArrayIterator<MenuItem>(this.menuItems);
        }

        // other menu methods here
    }
}