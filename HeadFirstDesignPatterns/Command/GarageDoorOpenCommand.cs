namespace HeadFirstDesignPatterns.Command
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            this.garageDoor.Up();
        }

        public void Undo()
        {
            this.garageDoor.Down();
        }
    }
}