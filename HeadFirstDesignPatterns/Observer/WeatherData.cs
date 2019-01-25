using System.Collections.Generic;

namespace HeadFirstDesignPatterns.Observer
{
    // This is the Subject
    public class WeatherData : ISubject
    {
        // The Subject's list of registered observers
        private List<IObserver> observers;

        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in this.observers)
            {
                observer.Update(this.Temperature, this.Humidity, this.Pressure); // PUSH model
                //observer.Update(this); // PULL model
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        // This will automatically be called by third-party Wheather Station object
        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        // This will be called to simulate the third-party Wheather Station
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;

            this.MeasurementsChanged();
        }

        // Other WheatherData methods here
    }
}
