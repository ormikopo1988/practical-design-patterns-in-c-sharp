namespace HeadFirstDesignPatterns.Decorator
{
    public class Mocha : ICondimentDecorator
    {
        private IBeverage beverage;

        public Mocha(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public string Description => beverage.Description + ", Mocha";

        public BeverageSize Size => beverage.Size;

        public double Cost()
        {
            double cost = beverage.Cost();

            switch(this.Size)
            {
                case BeverageSize.TALL:
                    cost += 0.10;
                    break;
                case BeverageSize.GRANDE:
                    cost += 0.15;
                    break;
                case BeverageSize.VENTI:
                    cost += 0.20;
                    break;
            }

            return cost;
        }
    }
}