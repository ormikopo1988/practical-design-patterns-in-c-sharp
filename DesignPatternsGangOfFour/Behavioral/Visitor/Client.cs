using DesignPatternsGangOfFour.Structural.Composite;

namespace DesignPatternsGangOfFour.Behavioral.Visitor
{
    public class Client
    {
        public void UseVisitorPattern()
        {
            Equipment component = new Card("aCard");
            PricingVisitor visitor = new PricingVisitor();

            component.Accept(visitor);

            // Total Price for component
            var totalPrice = visitor.TotalPrice;
        }
    }
}