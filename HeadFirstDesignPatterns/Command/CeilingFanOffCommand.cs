namespace HeadFirstDesignPatterns.Command
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this.ceilingFan.Off();
        }

        public void Undo()
        {
            this.ceilingFan.On();
        }
    }
}