namespace HeadFirstDesignPatterns.Iterator
{
    public interface IMenu<TRef>
        where TRef : class
    {
        Iterator<TRef> CreateIterator();
    }
}