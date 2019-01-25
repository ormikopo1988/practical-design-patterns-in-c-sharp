using HeadFirstDesignPatterns.Iterator;
using System.Collections;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Iterator
{
    public class MenuSimulator
    {
        public static void Start()
        {
            ArrayList menus = new ArrayList
            {
                new PancakeHouseMenu(),
                new DinerMenu(),
                new CafeMenu()
            };           
            
            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}