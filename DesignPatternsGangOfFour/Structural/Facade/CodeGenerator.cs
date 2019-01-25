namespace DesignPatternsGangOfFour.Structural.Facade
{
    public class CodeGenerator
    {
        protected BytecodeStream bytecodeStream;

        protected CodeGenerator(BytecodeStream bytecodeStream)
        {
            this.bytecodeStream = bytecodeStream;
        }

        public virtual void Visit(StatementNode statementNode)
        {
            // Some Implementation
        }

        public virtual void Visit(ExpressionNode expressionNode)
        {
            // Some Implementation
        }
    }
}