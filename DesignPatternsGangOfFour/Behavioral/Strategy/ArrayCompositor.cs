using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Behavioral.Strategy
{
    public class ArrayCompositor : ICompositor
    {
        private int interval;

        public ArrayCompositor(int interval)
        {
            this.interval = interval;
        }

        public int Compose(Coord[] natural, Coord[] stretch, Coord[] shrink, int componentCount, int lineWidth, int[] breaks)
        {
            // Some specific strategy implementation
            return 0;
        }
    }
}