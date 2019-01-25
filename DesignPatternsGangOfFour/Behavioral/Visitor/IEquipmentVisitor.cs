using DesignPatternsGangOfFour.Structural.Composite;

namespace DesignPatternsGangOfFour.Behavioral.Visitor
{
    public interface IEquipmentVisitor
    {
        void VisitFloppyDisk(FloppyDisk floppyDisk);

        void VisitCard(Card card);

        void VisitChassis(Chassis chassis);

        void VisitBus(Bus bus);

        // and so on for other concrete subclasses of Equipment
    }
}