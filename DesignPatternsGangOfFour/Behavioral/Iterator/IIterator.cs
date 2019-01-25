namespace DesignPatternsGangOfFour.Behavioral.Iterator
{
    public interface IIterator<TElem>
        where TElem : class
    {
        void First();
        void Next();
        bool IsDone();
        TElem CurrentItem();
    }
}