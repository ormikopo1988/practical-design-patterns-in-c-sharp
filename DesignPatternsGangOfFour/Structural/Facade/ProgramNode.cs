namespace DesignPatternsGangOfFour.Structural.Facade
{
    public class ProgramNode
    {
        // program node manipulation
        public virtual void GetSourcePosition(int line, int index)
        {
            // Some implementation
        }

        // . . .

        // child manipulation
        public virtual void Add(ProgramNode programNode)
        {
            // Some Implementation
        }

        public virtual void Remove(ProgramNode programNode)
        {
            // Some Implementation
        }

        // . . .

        public virtual void Traverse(CodeGenerator codeGenerator)
        {
            // Some implementation
        }
    }
}