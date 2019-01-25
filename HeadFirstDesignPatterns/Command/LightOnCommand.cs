namespace HeadFirstDesignPatterns.Command
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.On();
        }

        public void Undo()
        {
            this.light.Off();
        }
    }
}