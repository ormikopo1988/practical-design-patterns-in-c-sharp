namespace HeadFirstDesignPatterns.Command
{
    public class TVOnCommand : ICommand
    {
        private TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.On();
        }

        public void Undo()
        {
            this.tv.Off();
        }
    }
}