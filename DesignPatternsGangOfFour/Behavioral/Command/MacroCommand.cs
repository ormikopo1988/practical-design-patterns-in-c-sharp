using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Behavioral.Command
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> commands;

        public MacroCommand()
        {
            this.commands = new List<ICommand>();
        }

        public void Execute()
        {
            foreach(ICommand command in commands)
            {
                command.Execute();
            }
        }

        public void Add(ICommand command)
        {
            this.commands.Add(command);
        }

        public void Remove(ICommand command)
        {
            this.commands.Remove(command);
        }
    }
}