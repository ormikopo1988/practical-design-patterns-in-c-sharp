namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public abstract class Widget : HelpHandler
    {
        private Widget parent;

        protected Widget(Widget parent, Topic topic = Topic.NO_HELP_TOPIC)
            : base(parent, topic)
        {
            this.parent = parent;
        }
    }
}