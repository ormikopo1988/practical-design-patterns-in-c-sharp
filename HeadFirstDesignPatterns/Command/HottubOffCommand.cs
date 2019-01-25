namespace HeadFirstDesignPatterns.Command
{
    public class HottubOffCommand : ICommand
    {
        private Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            this.hottub.Off();
        }

        public void Undo()
        {
            this.hottub.On();
        }
    }
}