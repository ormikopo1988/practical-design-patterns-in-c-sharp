namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class NullIterator<T> : Iterator<T>
        where T : Equipment
    {
        public NullIterator()
        {
        }

        public override T First()
        {
            // empty set
            return null;
        }

        public override bool IsDone()
        {
            // empty set
            return true;
        }

        public override T Next()
        {
            // empty set
            return null;
        }

        public override T CurrentItem()
        {
            // empty set
            return null;
        }
    }
}