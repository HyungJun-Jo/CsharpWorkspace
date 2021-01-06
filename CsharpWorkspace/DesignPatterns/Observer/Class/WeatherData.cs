using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Class
{
    class WeatherData : Observable
    {
        //private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }


        public WeatherData()
        {

        }
        
        public void MeasurementsChanged()
        {
            // 기상 스체이션으로부터 갱신된 측정치를 받으면 옵저버들한테 알립니다.
            SetChanged();      
            NotifyObservers();
        }

        public void SetMesurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
