namespace HeadFirstDesignPatterns.Command
{
    public class StereoOffCommand : ICommand
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.Off();
        }

        public void Undo()
        {
            this.stereo.On();
        }
    }
}