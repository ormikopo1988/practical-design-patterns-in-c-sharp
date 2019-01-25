namespace HeadFirstDesignPatterns.Decorator
{
    public interface IBeverage
    {
        string Description { get; }

        BeverageSize Size { get; }

        double Cost();
    }
}