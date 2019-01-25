using System;

namespace DesignPatternsGangOfFour.Behavioral.Iterator
{
    public class ListIterator<TElem> : IIterator<TElem>
        where TElem : class
    {
        private List<TElem> list;
        private int current;

        public ListIterator(List<TElem> list)
        {
            this.list = list;
        }

        public TElem CurrentItem()
        {
            if(IsDone())
            {
                throw new Exception("Iterator out of bounds.");
            }

            return this.list.Get(this.current);
        }

        public void First()
        {
            this.current = 0;
        }

        public bool IsDone()
        {
            return this.current >= this.list.Count();
        }

        public void Next()
        {
            this.current++;
        }
    }
}