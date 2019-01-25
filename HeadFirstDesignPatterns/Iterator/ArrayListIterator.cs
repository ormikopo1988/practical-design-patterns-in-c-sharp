using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Iterator
{
    public class ArrayListIterator<TRef> : Iterator<TRef>
        where TRef : class
    {
        private ArrayList items;
        private int position = 0;

        public ArrayListIterator(ArrayList items)
        {
            this.items = items;
        }

        public TRef Next()
        {
            TRef menuItem = this.items[this.position] as TRef;

            this.position++;

            return menuItem;
        }

        public bool HasNext()
        {
            if (this.position >= this.items.Count || this.items[this.position] == null)
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
                for (int i = this.position - 1; i < (this.items.Count - 1); i++)
                {
                    this.items[i] = this.items[i + 1];
                }

                this.items[this.items.Count - 1] = null;
            }
        }
    }
}