using HeadFirstDesignPatterns.Singleton;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Singleton
{
    public class ChocolateBoilerControllerSimulator
    {
        public static void Start()
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

            boiler.Fill();
            boiler.Boil();
            boiler.Drain();
        }
    }
}