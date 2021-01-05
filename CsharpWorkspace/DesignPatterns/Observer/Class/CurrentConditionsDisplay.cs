using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Class;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        // IObserver : WeatherData 객체로부터 변경 사항을 받기 위해서 IObserver를 구현합니다.
        // IDisplayElement : API 구조상 모든 디스플레이 항목에서 DisplayElement를 구현하기로 했기 떄문에 이 인터페이스도 구현합니다.
        private Observable observable;
        private float temperature;
        private float humidity;


        public CurrentConditionsDisplay (Observable observable)
        {
            // 생성자에 weatherData 라는 주체 객체가 전달되며, 그 객체를 써서 디스플레이를 옵저버로 등록합니다.
            this.observable = observable;
            observable.AddObserver(this);
        }

        public void Update(Observable obs)
        {
            // Update가 호출되면 기온과 습도를 저장하고 Display()를 호출합니다.
            if (obs is WeatherData)
            {
                WeatherData weatherData = (WeatherData)obs;
                this.temperature = weatherData.GetTemperature();
                this.humidity = weatherData.GetHumidity();
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degress and {1}% humidity",temperature, humidity);
        }
    }
}
