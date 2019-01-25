using System.Text;

namespace HeadFirstDesignPatterns.Command
{
    // This is the Invoker in the Command Pattern
    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;

        public RemoteControl()
        {
            this.onCommands = new ICommand[7];
            this.offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                this.onCommands[i] = noCommand;
                this.offCommands[i] = noCommand;
            }

            this.undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            this.onCommands[slot].Execute();
            this.undoCommand = this.onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            this.offCommands[slot].Execute();
            this.undoCommand = this.offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            this.undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\n ------ Remote Control------- \n");

            for (int i = 0; i < 7; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + this.onCommands[i].GetType().Name + " " + this.offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}