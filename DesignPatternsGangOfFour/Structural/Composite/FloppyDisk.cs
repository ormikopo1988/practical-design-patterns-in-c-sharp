using DesignPatternsGangOfFour.Behavioral.Visitor;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class FloppyDisk : Equipment
    {
        public FloppyDisk(string name) 
            : base(name)
        {
        }

        public override Currency DiscountPrice()
        {
            return new Currency(10, CurrencyType.EUR);
        }

        public override Currency NetPrice()
        {
            return new Currency(15, CurrencyType.EUR);
        }

        public override Watt Power()
        {
            return new Watt(10);
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.VisitFloppyDisk(this);
        }
    }
}