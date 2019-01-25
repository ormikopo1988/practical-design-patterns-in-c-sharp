using DesignPatternsGangOfFour.Behavioral.Visitor;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Chassis : CompositeEquipment
    {
        public Chassis(string name) 
            : base(name)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            foreach(Equipment currentItem in this.Equipments)
            {
                currentItem.Accept(visitor);
            }

            visitor.VisitChassis(this);
        }
    }
}