namespace HeadFirstDesignPatterns.Command
{
    public class TVOffCommand : ICommand
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.Off();
        }

        public void Undo()
        {
            this.tv.On();
        }
    }
}