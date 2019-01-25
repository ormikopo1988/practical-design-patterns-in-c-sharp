namespace DesignPatternsGangOfFour.Behavioral.Command
{
    public class Document
    {
        private string name;

        public Document(string name)
        {
            this.name = name;
        }

        public void Open()
        {
            // Some implementation for opening the document
        }

        public void Paste()
        {
            // Some implementation for pasting
        }
    }
}