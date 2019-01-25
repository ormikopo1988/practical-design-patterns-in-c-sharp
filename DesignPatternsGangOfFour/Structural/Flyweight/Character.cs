namespace DesignPatternsGangOfFour.Structural.Flyweight
{
    public class Character : Glyph
    {
        // The intrinsic state would be just the character code for this concrete flyweight
        private readonly char charCode;

        public Character(char charCode)
        {
            this.charCode = charCode;
        }

        public override void Draw(Window window, GlyphContext context)
        {
            // Some specific implementation for drawing characters
            base.Draw(window, context);
        }
    }
}