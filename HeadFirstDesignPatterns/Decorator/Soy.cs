namespace HeadFirstDesignPatterns.Decorator
{
    public class Soy : ICondimentDecorator
    {
        private IBeverage beverage;

        public Soy(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public string Description => beverage.Description + ", Soy";

        public BeverageSize Size => beverage.Size;

        public double Cost()
        {
            double cost = beverage.Cost();

            switch (this.Size)
            {
                case BeverageSize.TALL:
                    cost += 0.30;
                    break;
                case BeverageSize.GRANDE:
                    cost += 0.35;
                    break;
                case BeverageSize.VENTI:
                    cost += 0.40;
                    break;
            }

            return cost;
        }
    }
}