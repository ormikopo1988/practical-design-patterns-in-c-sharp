namespace DesignPatternsGangOfFour.Behavioral.Observer
{
    public interface IObserver
    {
        void Update(Subject theChangedSubject);
    }
}