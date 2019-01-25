using System;
using System.Collections;

namespace HeadFirstDesignPatterns.Composite
{
    public class NullIterator : IEnumerator
    {
        public object Current => null;

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new InvalidOperationException();
        }
    }
}