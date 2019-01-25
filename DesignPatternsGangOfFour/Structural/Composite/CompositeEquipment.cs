using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class CompositeEquipment : Equipment
    {
        public List<Equipment> Equipments { get; private set; }

        public CompositeEquipment(string name) 
            : base(name)
        {
            this.Equipments = new List<Equipment>();
        }

        public override void Add(Equipment eq)
        {
            this.Equipments.Add(eq);
        }

        public override Iterator<Equipment> CreateIterator()
        {
            return base.CreateIterator();
        }

        public override Currency DiscountPrice()
        {
            Iterator<Equipment> i = CreateIterator();

            var totalDiscountPrice = 0.0;

            for (i.First(); !i.IsDone(); i.Next())
            {
                totalDiscountPrice += i.CurrentItem().DiscountPrice().Value;
            }

            return new Currency(totalDiscountPrice, CurrencyType.EUR);
        }

        public override Currency NetPrice()
        {
            Iterator<Equipment> i = CreateIterator();

            var totalNetPrice = 0.0;

            for (i.First(); !i.IsDone(); i.Next())
            {
                totalNetPrice += i.CurrentItem().NetPrice().Value;
            }
            
            return new Currency(totalNetPrice, CurrencyType.EUR);
        }

        public override Watt Power()
        {
            Iterator<Equipment> i = CreateIterator();

            var totalWattPower = 0.0;

            for (i.First(); !i.IsDone(); i.Next())
            {
                totalWattPower += i.CurrentItem().Power().Value;
            }

            return new Watt(totalWattPower);
        }

        public override void Remove(Equipment eq)
        {
            this.Equipments.Remove(eq);
        }
    }
}