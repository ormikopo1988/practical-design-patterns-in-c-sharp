using DesignPatternsGangOfFour.Structural.Composite;

namespace DesignPatternsGangOfFour.Behavioral.Visitor
{
    public class PricingVisitor : IEquipmentVisitor
    {
        public Currency TotalPrice { get; private set; }

        public PricingVisitor()
        {
            this.TotalPrice = new Currency(0.0, CurrencyType.EUR);
        }
        
        public void VisitBus(Bus bus)
        {
           this.TotalPrice.Value += bus.DiscountPrice().Value;
        }

        public void VisitCard(Card card)
        {
            this.TotalPrice.Value += card.NetPrice().Value;
        }

        public void VisitChassis(Chassis chassis)
        {
            this.TotalPrice.Value += chassis.DiscountPrice().Value;
        }

        public void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            this.TotalPrice.Value += floppyDisk.NetPrice().Value;
        }
    }
}