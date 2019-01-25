namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    public class Constant : IBooleanExp
    {
        private bool value;

        public Constant(bool value)
        {
            this.value = value;
        }

        public IBooleanExp Copy()
        {
            return new Constant(this.value);
        }

        public bool Evaluate(IContext context)
        {
            return this.value;
        }

        public IBooleanExp Replace(string name, IBooleanExp booleanExp)
        {
            return new Constant(this.value);
        }
    }
}