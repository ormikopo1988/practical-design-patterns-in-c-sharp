namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public class HelpHandler
    {
        private HelpHandler successor;
        private Topic topic;

        public HelpHandler(HelpHandler successor = null, Topic topic = Topic.NO_HELP_TOPIC)
        {
            this.successor = successor;
            this.topic = topic;
        }

        public virtual bool HasHelp()
        {
            return this.topic != Topic.NO_HELP_TOPIC;
        }

        public virtual void SetHandler(HelpHandler successor, Topic topic)
        {
            this.successor = successor;
            this.topic = topic;
        }

        public virtual void HandleHelp()
        {
            if(this.successor != null)
            {
                this.successor.HandleHelp();
            }
        }
    }
}