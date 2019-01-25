using DesignPatternsGangOfFour.Behavioral.Visitor;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Bus : CompositeEquipment
    {
        public Bus(string name) 
            : base(name)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.VisitBus(this);
        }
    }
}