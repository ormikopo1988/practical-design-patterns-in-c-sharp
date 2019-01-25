namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Watt
    {
        public double Value { get; private set; }

        public Watt()
        {
            this.Value = 0.0;
        }

        public Watt(double value)
        {
            this.Value = value;
        }
    }
}