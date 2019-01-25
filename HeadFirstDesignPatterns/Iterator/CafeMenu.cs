using System.Collections.Generic;

namespace HeadFirstDesignPatterns.Iterator
{
    public class CafeMenu : IMenu<MenuItem>
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            this.AddItem(
                "Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 
                3.99
            );

            this.AddItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 
                3.69
            );

            this.AddItem(
                "Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 
                4.29
            );
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            this.menuItems.Add(menuItem.Name, menuItem);
        }

        public Iterator<MenuItem> CreateIterator()
        {
            return new DictionaryIterator<string, MenuItem>(this.menuItems.Values);
        }
    }
}