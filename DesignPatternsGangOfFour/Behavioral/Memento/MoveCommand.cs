namespace DesignPatternsGangOfFour.Behavioral.Memento
{
    public class MoveCommand
    {
        private ConstraintSolverMemento state;
        private Point delta;
        private Graphic target;

        public MoveCommand(Graphic target, Point delta)
        {
            this.target = target;
            this.delta = delta;
        }

        public void Execute()
        {
            ConstraintSolver solver = ConstraintSolver.Instance();

            this.state = solver.CreateMemento(); // create a memento

            this.target.Move(this.delta);

            solver.Solve();
        }

        public void Unexecute()
        {
            ConstraintSolver solver = ConstraintSolver.Instance();

            this.target.Move(this.delta);

            solver.SetMemento(this.state); // restore solver state
            solver.Solve();
        }
    }
}