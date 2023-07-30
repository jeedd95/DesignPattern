using System;

namespace DesignPattern.Observer
{
    internal class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperatrue;
        private float humidity;
        private float pressure;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.temperatrue = weatherData.GetTemperature;
            this.humidity = weatherData.GetHumidity;
            this.pressure = weatherData.GetTemperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"현재 상태 : 온도 {temperatrue}F, 습도 {humidity}%");
        }
    }
}
