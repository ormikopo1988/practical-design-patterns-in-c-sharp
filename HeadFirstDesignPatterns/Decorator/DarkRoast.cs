namespace HeadFirstDesignPatterns.Decorator
{
    public class DarkRoast : IBeverage
    {
        public string Description => "Dark Roast Coffee";
        public BeverageSize Size { get; }

        public DarkRoast(BeverageSize beverageSize)
        {
            this.Size = beverageSize;
        }
        
        public double Cost()
        {
            return 1.23;
        }
    }
}