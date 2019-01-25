namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    // Defines the interface for all classes that define a Boolean expression
    public interface IBooleanExp
    {
        bool Evaluate(IContext context);
        IBooleanExp Replace(string name, IBooleanExp booleanExp);
        IBooleanExp Copy();
    }
}