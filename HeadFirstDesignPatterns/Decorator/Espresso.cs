namespace HeadFirstDesignPatterns.Decorator
{
    public class Espresso : IBeverage
    {
        public string Description => "Espresso";
        public BeverageSize Size { get; }

        public Espresso(BeverageSize beverageSize)
        {
            this.Size = beverageSize;
        }

        public double Cost()
        {
            return 1.99;
        }
    }
}