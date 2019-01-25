namespace DesignPatternsGangOfFour.Structural.Flyweight
{
    // This plays the role of a FlyweightFactory that creates glyphs and ensure they're shared properly
    public class GlyphFactory
    {
        private const int NCHARCODES = 128;
        private readonly Character[] characters = new Character[NCHARCODES];

        public GlyphFactory()
        {
            for (int i = 0; i < NCHARCODES; ++i)
            {
                characters[i] = null;
            }
        }

        public Character CreateCharacter(char c)
        {
            if (characters[c] != null)
            {
                characters[c] = new Character(c);
            }

            return characters[c];
        }

        // The other operations simply instantiate a new object each time they're called,
        // since noncharacter glyphs won't be shared
        public Row CreateRow()
        {
            return new Row();
        }

        public Column CreateColumn()
        {
            return new Column();
        }
    }
}