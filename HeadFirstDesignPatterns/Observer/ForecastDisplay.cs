using System;

namespace HeadFirstDesignPatterns.Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject wd)
        {
            this.weatherData = wd;

            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Forecast: some forecast logic.");
        }

        // PUSH model
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

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
                this.pressure = wd.Pressure;

                this.Display();
            }
        }
    }
}