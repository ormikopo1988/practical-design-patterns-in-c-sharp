namespace HeadFirstDesignPatterns.Command
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this.ceilingFan.On();
        }

        public void Undo()
        {
            this.ceilingFan.Off();
        }
    }
}