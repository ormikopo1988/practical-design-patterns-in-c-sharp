namespace DesignPatternsGangOfFour.Structural.Common
{
    public class Coord
    {
        public double Value { get; private set; }

        public Coord()
        {
            this.Value = 0.0;
        }

        public Coord(double value)
        {
            this.Value = value;
        }
    }
}