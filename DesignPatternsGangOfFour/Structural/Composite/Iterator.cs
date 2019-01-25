using System;

namespace DesignPatternsGangOfFour.Structural.Composite
{
    public class Iterator<T>
        where T : Equipment
    {
        public Iterator()
        {
        }

        public virtual T First()
        {
            // Implementation of Iterator Pattern
            throw new NotImplementedException();
        }

        public virtual bool IsDone()
        {
            // Implementation of Iterator Pattern
            throw new NotImplementedException();
        }

        public virtual T Next()
        {
            // Implementation of Iterator Pattern
            throw new NotImplementedException();
        }

        public virtual T CurrentItem()
        {
            // Implementation of Iterator Pattern
            throw new NotImplementedException();
        }
    }
}