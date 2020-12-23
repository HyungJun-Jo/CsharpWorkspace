using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 시나리오
            // - Car 라는 클래스가 있다.
            // - Property에는 Fuel가 있다.
            // - Go를 할때마다 Fuel가 5씩 소모된다.
            // - Car 클래스에는 Fuel가 20이하에 도달했을때 실행하는 이벤트를 게시한다.
            // - Main 에서는 해당 이벤트시에 표시되는 경고메세지를 입력한다.

            Car car = new Car();
            car.Fuel = 100;

            car.FuelEmptyReached += () => Console.WriteLine("Warning!! 연료부족!!");

            int num = 0;
            while (car.Fuel > 10)
            {
                num++;
                car.Go(num);
            }
            Console.ReadLine();
        }

    }
}






