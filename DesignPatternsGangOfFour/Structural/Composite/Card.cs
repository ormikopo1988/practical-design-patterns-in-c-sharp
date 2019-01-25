using DesignPatternsGangOfFour.Behavioral.Visitor;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Card : Equipment
    {
        public Card(string name)
            : base(name)
        {
        }

        public override Currency DiscountPrice()
        {
            return new Currency(5, CurrencyType.EUR);
        }

        public override Currency NetPrice()
        {
            return new Currency(10, CurrencyType.EUR);
        }

        public override Watt Power()
        {
            return new Watt(15);
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.VisitCard(this);
        }
    }
}