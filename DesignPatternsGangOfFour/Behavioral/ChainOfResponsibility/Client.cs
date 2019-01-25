namespace DesignPatternsGangOfFour.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        public void ShowHelp()
        {
            Application application = new Application(Topic.APPLICATION_TOPIC);
            Dialog dialog = new Dialog(application, Topic.PRINT_TOPIC);
            Button button = new Button(dialog, Topic.PAPER_ORIENTATION_TOPIC);

            // In this case, the button will handle the request immediately. Note that any
            // HelpHandler class could be made the successor of Dialog. Moreover, its successor
            // could be changed dynamically. So no matter where a dialog is used, you'll
            // get the proper context-dependent help information for it.
            button.HandleHelp();
        }
    }
}