namespace DesignPatternsGangOfFour.Structural.Flyweight
{
    // This is a base class for flyweight graphical objects
    public class Glyph
    {
        protected Glyph()
        {

        }

        public virtual void Draw(Window window, GlyphContext context)
        {
            // Some implementation
        }

        public virtual void SetFont(Font font, GlyphContext context)
        {
            // Some implementation
        }

        public virtual Font GetFont(GlyphContext context)
        {
            // Some implementation
            return new Font("some-font-name");
        }

        public virtual void First(GlyphContext context)
        {
            // Some implementation
        }

        public virtual void Next(GlyphContext context)
        {
            // Some implementation
        }

        public virtual bool IsDone(GlyphContext context)
        {
            // Some implementation
            return true;
        }

        public virtual Glyph Current(GlyphContext context)
        {
            // Some implementation
            return null;
        }

        public virtual void Insert(Glyph glyph, GlyphContext context)
        {
            // Some implementation
        }

        public virtual void Remove(GlyphContext context)
        {
            // Some implementation
        }
    }
}