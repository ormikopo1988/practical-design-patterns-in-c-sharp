using System;

namespace HeadFirstDesignPatterns.Iterator
{
    public class ArrayIterator<TRef> : Iterator<TRef>
        where TRef : class
    {
        private TRef[] items;
        private int position = 0;

        public ArrayIterator(TRef[] items)
        {
            this.items = items;
        }

        public TRef Next()
        {
            TRef menuItem = this.items[this.position];

            this.position++;

            return menuItem;
        }

        public bool HasNext()
        {
            if (this.position >= this.items.Length || this.items[this.position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Remove()
        {
            if (this.position <= 0)
            {
                throw new InvalidOperationException("You can’t remove an item until you’ve done at least one Next().");
            }

            if (this.items[this.position - 1] != null)
            {
                for (int i = this.position - 1; i < (this.items.Length - 1); i++)
                {
                    this.items[i] = this.items[i + 1];
                }

                this.items[this.items.Length - 1] = null;
            }
        }
    }
}