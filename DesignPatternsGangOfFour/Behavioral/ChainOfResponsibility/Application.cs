namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public class Application : HelpHandler
    {
        public Application(Topic topic)
            : base(null, topic)
        {

        }

        public override void HandleHelp()
        {
            // show a list of help topics
        }

        // application-specific operations...
    }
}