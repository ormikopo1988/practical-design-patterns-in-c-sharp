namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    public class Context : IContext
    {
        public void Assign(VariableExp variableExp, bool res)
        {
            // Some implementation
        }

        public bool Lookup(string name)
        {
            // Some implementation
            return true;
        }
    }
}