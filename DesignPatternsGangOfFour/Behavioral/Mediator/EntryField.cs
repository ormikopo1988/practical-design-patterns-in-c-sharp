namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    public class EntryField : Widget
    {
        private string text;

        public EntryField(DialogDirector dialogDirector) 
            : base(dialogDirector)
        {
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return this.text;
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            this.Changed();
        }

        // ... 
    }
}