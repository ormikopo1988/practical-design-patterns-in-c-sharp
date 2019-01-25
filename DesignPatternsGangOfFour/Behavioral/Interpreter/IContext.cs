namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    // Defines mapping from variables to Boolean values, which we
    // represent with the C# constants true and false
    public interface IContext
    {
        bool Lookup(string name);
        void Assign(VariableExp variableExp, bool res);
    }
}