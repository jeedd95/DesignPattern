namespace DesignPattern.Observer
{
    internal class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMesurements(80f, 65f, 30.4f);
            weatherData.SetMesurements(82f, 70f, 29.2f);
            weatherData.SetMesurements(78f, 90f, 29.4f);
        }
    }
}
