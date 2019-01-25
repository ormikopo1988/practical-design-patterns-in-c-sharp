namespace DesignPatternsGangOfFour.Structural.Common
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point()
        {
            this.X = 0.0;
            this.Y = 0.0;
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}