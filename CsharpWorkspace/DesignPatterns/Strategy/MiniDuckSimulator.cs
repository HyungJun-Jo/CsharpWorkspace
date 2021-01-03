using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class MiniDuckSimulator
    {
        public static void Main()
        {
            // 스트래티지 패턴(Strategy Pattern)
            // - 알고리즘을 정의하고 각각을 캡슐화하여 교환해서 사용할 수 있도록 만든다.
            // - 알고리즘을 사용하는 클라이언트와는 독립적으로 알고리즘을 변경할 수 있다.

            // MallardDuck에서 행동을 부여해줌으로서 공통코드와 구분코드를 분할하여 개발할 수 있다.
            Duck mallard = new MallardDuck();
            mallard.Display();                                  // 공통함수로 모든 Duck이 가지고 있는 함수
            mallard.PerformFly();                               // Duck의 종류마다 다른 기능을 가져야 함으로 인터페이스를 활용한 Strategy Pattern을 사용하여 각 클래스별로 기능을 별도 정의 가능하도록 한다.
            mallard.PerformQuack();
            Console.ReadLine();

            // 동적으로 행동을 부여도 가능하다.
            Duck model = new ModelDuck();
            model.Display();                                    
            model.PerformFly();                                 // 초기값

            Console.WriteLine("행동 변경!");
            model.SetFlyBehavior(new FlyRocketPowered());       // 행동 세터 메소드를 호출. 추진력으로 날 수 있는 능력이 생겼습니다.
            model.PerformFly();                                 // 변경된 행동 메소드                           
            Console.ReadLine();
        }
    }
}
