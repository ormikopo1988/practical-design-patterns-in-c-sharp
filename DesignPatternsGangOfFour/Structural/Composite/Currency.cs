namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Currency
    {
        public double Value { get; set; }

        public CurrencyType CurrencyType { get; set; }

        public Currency()
        {
            this.Value = 0.0;
            this.CurrencyType = CurrencyType.NONE;
        }

        public Currency(double value, CurrencyType currencyType)
        {
            this.Value = value;
            this.CurrencyType = currencyType;
        }
    }

    public enum CurrencyType
    {
        NONE = 0,
        EUR = 1,
        USD = 2
    }
}