namespace HeadFirstDesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}