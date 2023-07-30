using System.Collections.Generic;

namespace DesignPattern.Observer
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public float GetTemperature { get => temperature; }
        public float GetHumidity { get => humidity; }
        public float GetPressure { get => pressure; }

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void UnregisterObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void SetMesurements(float temperature, float humidity, float pressure)
        {
            this.temperature=temperature;
            this.humidity=humidity;
            this.pressure=pressure;
            MeasurementsChanged();
        }
    }
}
