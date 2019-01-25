namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public class Dialog : Widget
    {
        public Dialog(HelpHandler parent, Topic topic = Topic.NO_HELP_TOPIC) 
            : base(null)
        {
            this.SetHandler(parent, topic);
        }

        public override void HandleHelp()
        {
            if (this.HasHelp())
            { 
                // offer help on the dialog
            }
            else
            {
                base.HandleHelp();
            }
        }

        // Widget operations that Dialog overrides...
        // . ..
    }
}