namespace HeadFirstDesignPatterns.Command
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            this.garageDoor.Down();
        }

        public void Undo()
        {
            this.garageDoor.Up();
        }
    }
}