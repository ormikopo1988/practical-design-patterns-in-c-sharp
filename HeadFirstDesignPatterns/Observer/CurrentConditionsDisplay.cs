using System;

namespace HeadFirstDesignPatterns.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject wd)
        {
            this.weatherData = wd;

            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {this.temperature}F degrees and {this.humidity}% humidity.");
        }

        // PUSH Model
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;

            this.Display();
        }

        // PULL model
        public void Update(ISubject subject)
        {
            if (subject is WeatherData)
            {
                WeatherData wd = (WeatherData)subject;

                this.temperature = wd.Temperature;
                this.humidity = wd.Humidity;

                this.Display();
            }
        }
    }
}