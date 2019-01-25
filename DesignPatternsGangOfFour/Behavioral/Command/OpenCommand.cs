namespace DesignPatternsGangOfFour.Behavioral.Command
{
    public class OpenCommand : ICommand
    {
        private Application application;
        private string response;
        
        public OpenCommand(Application application)
        {
            this.application = application;
        }

        public void Execute()
        {
            string name = AskUser();

            if (!string.IsNullOrEmpty(name))
            {
                Document document = new Document(name);

                application.Add(document);

                document.Open();
            }
        }

        public string AskUser()
        {
            // an implementation routine that prompts the user for the name of
            // the document to open
            this.response = "someDocumentNameFromTheUser";

            return this.response;
        }
    }
}