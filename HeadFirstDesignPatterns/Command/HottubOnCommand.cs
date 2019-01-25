namespace HeadFirstDesignPatterns.Command
{
    public class HottubOnCommand : ICommand
    {
        private Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            this.hottub.On();
        }

        public void Undo()
        {
            this.hottub.Off();
        }
    }
}