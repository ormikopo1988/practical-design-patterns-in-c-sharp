using System.Collections;

namespace HeadFirstDesignPatterns.Iterator
{
    public class PancakeHouseMenu : IMenu<MenuItem>
    {
        private ArrayList menuItems;

        public PancakeHouseMenu()
        {
            this.menuItems = new ArrayList();

            this.AddItem(
                "K & B’s Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99
            );

            this.AddItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99
            );

            this.AddItem(
                "Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49
            );

            this.AddItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59
            );
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            this.menuItems.Add(new MenuItem(name, description, isVegetarian, price));
        }

        public Iterator<MenuItem> CreateIterator()
        {
            return new ArrayListIterator<MenuItem>(this.menuItems);
        }

        // Other menu methods here
    }
}