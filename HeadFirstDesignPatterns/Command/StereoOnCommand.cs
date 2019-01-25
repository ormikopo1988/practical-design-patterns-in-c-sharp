namespace HeadFirstDesignPatterns.Command
{
    public class StereoOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.On();
        }

        public void Undo()
        {
            this.stereo.Off();
        }
    }
}