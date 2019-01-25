namespace DesignPatternsGangOfFour.Behavioral.Memento
{
    public class ConstraintSolver
    {
        // Private properties
        // nontrivial state and operations for enforcing
        // connectivity semantics

        private static ConstraintSolver instance = null;

        public static ConstraintSolver Instance()
        {
            if(instance == null)
            {
                instance = new ConstraintSolver();
            }

            return instance;
        }

        private ConstraintSolver()
        {

        }

        public void Solve()
        {
            // Some implementation
        }

        public void AddConstraint(Graphic startConnection, Graphic endConnection)
        {
            // Some implementation
        }

        public void RemoveConstraint(Graphic startConnection, Graphic endConnection)
        {
            // Some implementation
        }

        public ConstraintSolverMemento CreateMemento()
        {
            return new ConstraintSolverMemento();
        }

        public void SetMemento(ConstraintSolverMemento constraintSolverMemento)
        {
            // Some implementation
        }
    }
}