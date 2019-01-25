namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    // Represents an expression made by NOTing a boolean expression
    public class NotExp : IBooleanExp
    {
        private IBooleanExp operand;

        public NotExp(IBooleanExp operand)
        {
            this.operand = operand;
        }

        public IBooleanExp Copy()
        {
            return
                new NotExp(this.operand.Copy());
        }

        public bool Evaluate(IContext aContext)
        {
            return
                !this.operand.Evaluate(aContext);
        }

        public IBooleanExp Replace(string name, IBooleanExp booleanExp)
        {
            return
                new NotExp(this.operand.Replace(name, booleanExp));
        }
    }
}
