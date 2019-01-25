using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Behavioral.Strategy
{
    public class TeXCompositor : ICompositor
    {
        public int Compose(Coord[] natural, Coord[] stretch, Coord[] shrink, int componentCount, int lineWidth, int[] breaks)
        {
            // Some specific strategy implementation
            return 0;
        }
    }
}