using System;

namespace DesignPatternsGangOfFour.Behavioral.Iterator
{
    public class ReverseListIterator<TElem> : IIterator<TElem>
        where TElem : class
    {
        private List<TElem> list;
        private int current;

        public ReverseListIterator(List<TElem> list)
        {
            this.list = list;
        }

        public TElem CurrentItem()
        {
            if (IsDone())
            {
                throw new Exception("Iterator out of bounds.");
            }

            return this.list.Get(this.current);
        }

        public void First()
        {
            this.current = (this.list.Count() - 1);
        }

        public bool IsDone()
        {
            return this.current <= 0;
        }

        public void Next()
        {
            this.current--;
        }
    }
}