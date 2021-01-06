using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Class;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            // 옵저버 패턴 (Observer Pattern)
            // - Observable 객체를 써서 옵저버에 연락을 합니다.
            // - 서로 상호작용을 하는 객체 사이에서 느슨하게 결합하는 디자인을 할때 사용합니다.

            WeatherData weatherData = new WeatherData();        // weatherData 객체는 Observable 객체를 상속받는다.

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);      // weatherData 객체를 인자값으로 받으며, 자기 자신을 옵저버로 등록시킵니다.

            weatherData.SetMesurements(80, 65, 30.4f);          // SetMeasurements 메소드가 실행되면서 옵저버들에게 변경되었음을 notify하고 

            Console.ReadLine();
        }
    }
}
