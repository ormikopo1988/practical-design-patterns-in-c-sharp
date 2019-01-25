namespace HeadFirstDesignPatterns.Decorator
{
    public class HouseBlend : IBeverage
    {
        public string Description => "House Blend Coffee";
        public BeverageSize Size { get; }

        public HouseBlend(BeverageSize beverageSize)
        {
            this.Size = beverageSize;
        }

        public double Cost()
        {
            return 0.89;
        }
    }
}