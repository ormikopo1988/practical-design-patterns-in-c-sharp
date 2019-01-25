namespace HeadFirstDesignPatterns.Command
{
    public class MacroCommand : ICommand
    {
        private ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < this.commands.Length; i++)
            {
                this.commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < this.commands.Length; i++)
            {
                this.commands[i].Undo();
            }
        }
    }
}