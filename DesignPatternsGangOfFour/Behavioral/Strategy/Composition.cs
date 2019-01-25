using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Behavioral.Strategy
{
    public class Composition
    {
        private ICompositor compositor;

        private Component components = null; // the list of components

        private int componentCount = 0; // the number of components

        private int lineWidth = 0; // the Composition's line width

        private int lineBreaks = 0; // the position of linebreaks
                                // in components

        private int lineCount = 0; // the number of lines

        public Composition(ICompositor compositor)
        {
            this.compositor = compositor;
        }

        public void Repair()
        {
            Coord[] natural = new Coord[1];
            Coord[] stretchability = new Coord[1];
            Coord[] shrinkability = new Coord[1];

            int componentCount = 0;
            int[] breaks = new int[1];

            // prepare the arrays with the desired component sizes
            // . . .
            // determine where the breaks are:
            
            int breakCount = this.compositor.Compose(
                natural, stretchability, shrinkability,
                componentCount, lineWidth, breaks
            );

            // lay out components according to breaks
            // . . .
        }
    }
}