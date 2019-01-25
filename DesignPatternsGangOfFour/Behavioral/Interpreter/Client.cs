namespace DesignPatternsGangOfFour.Behavioral.Interpreter
{
    public class Client
    {
        // (true and x) or (y and (not x))
        public void EvaluateExpression()
        {
            IBooleanExp expression;
            IContext context = new Context();

            VariableExp x = new VariableExp("X");
            VariableExp y = new VariableExp("Y");

            expression = new OrExp(
                new AndExp(new Constant(true), x),
                new AndExp(y, new NotExp(x))
            );

            context.Assign(x, false);
            context.Assign(y, true);

            bool result = expression.Evaluate(context);
        }
    }
}