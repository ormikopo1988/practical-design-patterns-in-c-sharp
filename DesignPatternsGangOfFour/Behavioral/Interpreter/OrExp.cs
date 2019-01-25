namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    // Represents an expression made by ORing two Boolean expressions together
    public class OrExp : IBooleanExp
    {
        private IBooleanExp operand1;
        private IBooleanExp operand2;

        public OrExp(IBooleanExp operand1, IBooleanExp operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public IBooleanExp Copy()
        {
            return
                new OrExp(this.operand1.Copy(), this.operand2.Copy());
        }

        public bool Evaluate(IContext aContext)
        {
            return
                this.operand1.Evaluate(aContext) ||
                this.operand2.Evaluate(aContext);
        }

        public IBooleanExp Replace(string name, IBooleanExp booleanExp)
        {
            return
                new OrExp(
                    this.operand1.Replace(name, booleanExp),
                    this.operand2.Replace(name, booleanExp)
                );
        }
    }
}
