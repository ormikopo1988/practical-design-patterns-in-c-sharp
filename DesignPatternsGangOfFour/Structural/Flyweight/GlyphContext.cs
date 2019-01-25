using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Structural.Flyweight
{
    public class GlyphContext
    {
        // Some needed extrinsic state information of the context that the flyweight lives goes here
        private readonly int index;
        private readonly Dictionary<int, Font> fonts;

        public GlyphContext()
        {
            this.index = 0;
            this.fonts = new Dictionary<int, Font>();
        }

        public virtual void Next(int step = 1)
        {
            // Some implementation
        }

        public virtual void Insert(int quantity = 1)
        {
            // Some implementation
        }

        public virtual Font GetFont()
        {
            // Some implementation e.g.
            fonts.TryGetValue(this.index, out Font result);

            return result;
        }

        public virtual void SetFont(Font font, int span = 1)
        {
            // Some implementation
        }
    }
}