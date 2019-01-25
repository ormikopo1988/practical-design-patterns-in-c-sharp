namespace HeadFirstDesignPatterns.Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.On();
            this.stereo.SetCD();
            this.stereo.SetVolume(11);
        }

        public void Undo()
        {
            this.stereo.Off();
        }
    }
}