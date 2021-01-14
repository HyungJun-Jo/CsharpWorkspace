using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class StarbucksCoffee
    {
        public static void Main()
        {
            // 데코레이터 패턴 (Decorator Pattern)
            // - 객체에 추가 요소를 동적으로 더할 수 있습니다.
            // - 데코레이터를 사용하면 서브클래스를 만드는 경우에 비해 훨씬 유연하게 기능을 확장할 수 있습니다.

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost().ToString());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);               // 추가 요소가 기존 객체를 감쌉니다.
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost().ToString());     // 추가 요소들의 결과값이 누적되어 출력됩니다.

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost().ToString());

            Console.ReadLine();
        }
    }
}
