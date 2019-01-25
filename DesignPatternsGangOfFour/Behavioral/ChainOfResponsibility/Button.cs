namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public class Button : Widget
    {
        public Button(Widget parent, Topic topic = Topic.NO_HELP_TOPIC) 
            : base(parent, topic)
        {
        }

        public override void HandleHelp()
        {
            if(this.HasHelp())
            {
                // offer help on the button
            }
            else
            {
                base.HandleHelp();
            }
        }

        // Widget operations that Button overrides...
        // ...
    }
}