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
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMesurements(80, 65, 30.4f);

            Console.ReadLine();
        }
    }
}
