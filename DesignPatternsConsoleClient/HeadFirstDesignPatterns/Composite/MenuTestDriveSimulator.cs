using HeadFirstDesignPatterns.Composite;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Composite
{
    public class MenuTestDriveSimulator
    {
        public static void Start()
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            pancakeHouseMenu.Add(
                new MenuItem(
                    "Pancake",
                    "Pancake with strawberry ice cream",
                    false,
                    1.29
                )
            );

            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(
                new MenuItem(
                    "Cappuccino",
                    "Cappuccino latte with cream and chocolate",
                    false,
                    1.59
                )
            );

            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            dessertMenu.Add(
                new MenuItem(
                    "Apple Pie",
                    "Apple pie with a flakey crust, topped with vanilla icecream",
                    true,
                    1.59
                )
            );

            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(
                new MenuItem(
                    "Pasta",
                    "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                    true,
                    3.89
                )
            );
            dinerMenu.Add(dessertMenu);

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            
            Waitress waitress = new Waitress(allMenus);

            //waitress.PrintMenu();
            waitress.PrintVegetarianMenu();
            //TestCompositeIterator.Start(allMenus);
        }
    }
}