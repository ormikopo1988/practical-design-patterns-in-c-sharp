namespace HeadFirstDesignPatterns.Command
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this.prevSpeed = ceilingFan.Speed;
            this.ceilingFan.High();
        }

        public void Undo()
        {
            if (this.prevSpeed == CeilingFan.HIGH)
            {
                this.ceilingFan.High();
            }
            else if (this.prevSpeed == CeilingFan.MEDIUM)
            {
                this.ceilingFan.Medium();
            }
            else if (this.prevSpeed == CeilingFan.LOW)
            {
                this.ceilingFan.Low();
            }
            else if (this.prevSpeed == CeilingFan.OFF)
            {
                this.ceilingFan.Off();
            }
        }
    }
}