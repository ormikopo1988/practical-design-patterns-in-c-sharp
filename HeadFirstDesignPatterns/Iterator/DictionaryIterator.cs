using System;
using System.Collections.Generic;

namespace HeadFirstDesignPatterns.Iterator
{
    public class DictionaryIterator<TKey, TValueRef> : Iterator<TValueRef>
        where TValueRef : class
    {
        private Dictionary<TKey, TValueRef>.ValueCollection items;
        private TValueRef[] valueItems;
        private int position = 0;

        public DictionaryIterator(Dictionary<TKey, TValueRef>.ValueCollection items)
        {
            this.items = items;

            this.valueItems = new TValueRef[this.items.Count];
            this.items.CopyTo(this.valueItems, 0);
        }

        public bool HasNext()
        {
            if (position >= this.valueItems.Length || this.valueItems[this.position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public TValueRef Next()
        {
            TValueRef menuItem = this.valueItems[this.position];

            this.position++;

            return menuItem;
        }

        public void Remove()
        {
            if (this.position <= 0)
            {
                throw new InvalidOperationException("You can’t remove an item until you’ve done at least one Next().");
            }

            if (this.valueItems[this.position - 1] != null)
            {
                for (int i = this.position - 1; i < (this.valueItems.Length - 1); i++)
                {
                    this.valueItems[i] = this.valueItems[i + 1];
                }

                this.valueItems[this.valueItems.Length - 1] = null;
            }
        }
    }
}