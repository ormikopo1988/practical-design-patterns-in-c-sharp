namespace HeadFirstDesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure); // PUSH model
        void Update(ISubject subject); // PULL model
    }
}