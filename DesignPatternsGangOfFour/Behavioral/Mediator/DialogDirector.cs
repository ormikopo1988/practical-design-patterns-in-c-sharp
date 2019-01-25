namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    // Defines the interface for directors (mediators)
    public abstract class DialogDirector
    {
        public void ShowDialog()
        {
            // Some Implementation
        }

        public abstract void WidgetChanged(Widget theChangedWidget);

        protected abstract void CreateWidgets();
    }
}