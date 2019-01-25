namespace HeadFirstDesignPatterns.Command
{
    public class SimpleRemoteControl
    {
        private ICommand slot;
        
        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            this.slot.Execute();
        }
    }
}