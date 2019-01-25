namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    // Abstract base class for widgets
    public abstract class Widget
    {
        protected DialogDirector dialogDirector;

        public Widget(DialogDirector dialogDirector)
        {
            this.dialogDirector = dialogDirector;
        }

        public virtual void Changed()
        {
            this.dialogDirector.WidgetChanged(this);
        }

        public virtual void HandleMouse(MouseEvent mouseEvent)
        {
            // Some implementation
        }
    }
}