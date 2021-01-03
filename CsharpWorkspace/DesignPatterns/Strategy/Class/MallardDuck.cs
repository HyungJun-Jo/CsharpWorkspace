using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackQuack();               // Duck 에서 상속받은 인스턴스 변수로 해당 기능을 클래스 객체 생성을 통해 부여하도록 한다.
            flyBehavior = new FlyWithWings();               // Mallard Duck 은 "꽥꽥" 소리와 "날고 있어요" 텍스트를 출력하도록 부여하였다.
        }

        public override void Display()
        {
            Console.WriteLine("저는 물오리 입니다!");       // Display는 Duck의 추상메소드로 공통적으로 부여된 기능이며 각각의 Duck 종류별로 정의가 필요하다.
        }
    }
}
