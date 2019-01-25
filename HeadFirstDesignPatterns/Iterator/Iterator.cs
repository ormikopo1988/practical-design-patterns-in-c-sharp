namespace HeadFirstDesignPatterns.Iterator
{
    public interface Iterator<TRef>
        where TRef : class
    {
        bool HasNext();
        TRef Next();
        void Remove();
    }
}