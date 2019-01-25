using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Behavioral.Strategy
{
    public interface ICompositor
    {
        int Compose(
            Coord[] natural, 
            Coord[] stretch, 
            Coord[] shrink, 
            int componentCount, 
            int lineWidth, 
            int[] breaks
        );
    }
}