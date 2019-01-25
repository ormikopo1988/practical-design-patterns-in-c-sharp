namespace DesignPatternsGangOfFour.Behavioral.Strategy
{
    public class Client
    {
        public void ConsumeStrategyAlgorithms()
        {
            Composition quick = new Composition(new SimpleCompositor());
            Composition slick = new Composition(new TeXCompositor());
            Composition iconic = new Composition(new ArrayCompositor(100));
        }
    }
}