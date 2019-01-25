using DesignPatternsGangOfFour.Behavioral.Visitor;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Equipment
    {
        public string Name { get; private set; }

        public Equipment(string name)
        {
            this.Name = name;
        }

        public virtual Watt Power()
        {
            return new Watt();
        }

        public virtual Currency NetPrice()
        {
            return new Currency();
        }

        public virtual Currency DiscountPrice()
        {
            return new Currency();
        }

        public virtual void Add(Equipment eq)
        {
            // Default implementation for both leaves and composites
        }

        public virtual void Remove(Equipment eq)
        {
            // Default implementation for both leaves and composites
        }

        public virtual Iterator<Equipment> CreateIterator()
        {
            // The default implementation for this operation returns a Nulllterator, which iterates
            // over the empty set.
            return new NullIterator<Equipment>();
        }

        public virtual void Accept(IEquipmentVisitor visitor)
        {
            // Default implementation
        }
    }
}