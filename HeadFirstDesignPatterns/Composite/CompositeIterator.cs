using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Composite
{
    public class CompositeIterator : IEnumerator
    {
        private Stack stack = new Stack();

        public CompositeIterator(IEnumerator enumerator)
        {
            this.stack.Push(enumerator);
        }

        public object Current
        {
            get
            {
                IEnumerator iterator = null;

                try
                {
                    iterator = this.stack.Peek() as IEnumerator;
                }
                catch (Exception)
                {
                    return null;
                }

                if(iterator == null)
                {
                    return null;
                }
                else
                {
                    MenuComponent component = iterator.Current as MenuComponent;

                    if (component is Menu)
                    {
                        var componentIterator = component.CreateIterator();

                        this.stack.Push(componentIterator);
                    }

                    return component;
                }
            }
        }

        public bool MoveNext()
        {
            IEnumerator iterator = null;

            try
            {
                iterator = this.stack.Peek() as IEnumerator;
            }
            catch (Exception) {}

            if (iterator == null)
            {
                return false;
            }
            else
            {
                if (!iterator.MoveNext())
                {
                    this.stack.Pop();

                    return this.MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new InvalidOperationException();
        }
    }
}