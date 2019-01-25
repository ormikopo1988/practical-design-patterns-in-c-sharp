namespace DesignPatternsGangOfFour.Structural.Proxy
{
    public class Client
    {
        public void InsertGlyphIntoTextDocument()
        {
            TextDocument text = new TextDocument();

            // ...

            text.Insert(new ImageProxy("anImageFileName"));
        }
    }
}