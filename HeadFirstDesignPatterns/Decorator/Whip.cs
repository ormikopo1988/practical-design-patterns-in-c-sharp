namespace HeadFirstDesignPatterns.Decorator
{
    public class Whip : ICondimentDecorator
    {
        private IBeverage beverage;

        public Whip(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public string Description => beverage.Description + ", Whip";

        public BeverageSize Size => beverage.Size;

        public double Cost()
        {
            double cost = beverage.Cost();

            switch (this.Size)
            {
                case BeverageSize.TALL:
                    cost += 0.05;
                    break;
                case BeverageSize.GRANDE:
                    cost += 0.10;
                    break;
                case BeverageSize.VENTI:
                    cost += 0.15;
                    break;
            }

            return cost;
        }
    }
}