using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class WebAPIClient
    {
        public static void Main()
        {
            // 싱글턴 패턴 (Singleton Pattern)
            // - 어떤 클래스에 싱글턴 패턴을 적용하면 애플리케이션에 그 클래스의 인스턴스가 최대 한개 까지만 있도록 할 수 있습니다.
            // - 싱글턴 패턴을 이용하면 유일한 인스턴스를 어디서든지 접근할 수 있습니다.
            // - 전역변수와 다르게 최초사용시에 생성되므로 메모리 부하가 적다는 장점이 있습니다.

            CurrentUser.Instance.UserName = "JO HYUNG JUN";         // CurrentUse 클래스를 사용하는 동시에 Singleton 객체가 생성됨
            CurrentUser.Instance.EmpNo = "20180901";
                
            UserInfoDisplay.Display();                              // 다른 클래스에서 해당 값에 접근 가능

            Console.ReadLine();
        }
    }
}
