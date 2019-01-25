namespace DesignPatternsGangOfFour.Behavioral.Command
{
    public class PasteCommand : ICommand
    {
        private Document document;

        public PasteCommand(Document document)
        {
            this.document = document;
        }

        public void Execute()
        {
            this.document.Paste();
        }
    }
}