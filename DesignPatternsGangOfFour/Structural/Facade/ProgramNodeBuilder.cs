namespace DesignPatternsGangOfFour.Structural.Facade
{
    public class ProgramNodeBuilder
    {
        public virtual ProgramNode NewVariable(string variableName)
        {
            // Some Implementation
            throw new System.NotImplementedException();
        }

        public virtual ProgramNode NewAssignment(ProgramNode variable, ProgramNode expression)
        {
            // Some Implementation
            throw new System.NotImplementedException();
        }

        public virtual ProgramNode NewReturnStatement(ProgramNode value)
        {
            // Some Implementation
            throw new System.NotImplementedException();
        }

        public virtual ProgramNode NewCondition(ProgramNode condition, ProgramNode truePart, ProgramNode falsePart)
        {
            // Some Implementation
            throw new System.NotImplementedException();
        }

        public ProgramNode GetRootNode()
        {
            // Some Implementation
            throw new System.NotImplementedException();
        }
    }
}