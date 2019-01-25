using System;

namespace HeadFirstDesignPatterns.Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject wd)
        {
            this.weatherData = wd;

            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Statistics: {this.temperature}F degrees.");
        }

        // PUSH model
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;

            this.Display();
        }

        // PULL model
        public void Update(ISubject subject)
        {
            if (subject is WeatherData)
            {
                WeatherData wd = (WeatherData)subject;

                this.temperature = wd.Temperature;

                this.Display();
            }
        }
    }
}