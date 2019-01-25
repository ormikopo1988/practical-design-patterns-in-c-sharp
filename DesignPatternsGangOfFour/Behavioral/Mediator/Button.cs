namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    public class Button : Widget
    {
        private string buttonText;

        public Button(DialogDirector dialogDirector) 
            : base(dialogDirector)
        {
        }

        public void SetText(string text)
        {
            this.buttonText = text;
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            // ...
            this.Changed();
        }
    }
}