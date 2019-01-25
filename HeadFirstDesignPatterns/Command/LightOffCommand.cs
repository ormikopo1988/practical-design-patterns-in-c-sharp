namespace HeadFirstDesignPatterns.Command
{
    public class LightOffCommand : ICommand
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.Off();
        }

        public void Undo()
        {
            this.light.On();
        }
    }
}