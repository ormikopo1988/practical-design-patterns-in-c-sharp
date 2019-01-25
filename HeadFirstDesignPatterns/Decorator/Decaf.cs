namespace HeadFirstDesignPatterns.Decorator
{
    public class Decaf : IBeverage
    {
        public string Description => "Decaf";
        public BeverageSize Size { get; }

        public Decaf(BeverageSize beverageSize)
        {
            this.Size = beverageSize;
        }

        public double Cost()
        {
            return 0.98;
        }
    }
}