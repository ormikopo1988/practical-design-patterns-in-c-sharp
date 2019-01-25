namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    // Represents a named variable
    public class VariableExp : IBooleanExp
    {
        private string name;

        public VariableExp(string name)
        {
            this.name = name.ToUpper();
        }

        public IBooleanExp Copy()
        {
            return new VariableExp(this.name);
        }

        public bool Evaluate(IContext aContext)
        {
            return aContext.Lookup(this.name);
        }

        public IBooleanExp Replace(string name, IBooleanExp booleanExp)
        {
            if (this.name == name)
            {
                return booleanExp.Copy();
            }
            else
            {
                return new VariableExp(this.name);
            }
        }
    }
}