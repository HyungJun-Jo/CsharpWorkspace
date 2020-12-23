using System;

namespace Event_Delegate
{

    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;     // 델리게이트 인스턴스 생성(이벤트 한정자)

        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);         // 2) 이벤트 발생  -->  참조하는 메소드(MyHandler) 호출 
        }
    }

    class Delegate
    {

        static public void MyHandler(int i)
        {
            Console.WriteLine("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", i);   // 3) 메소드 작동
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(MyHandler);     // 1) 호출자가 호출 시도 ---> 4) 실행결과 받음

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);
        }
    }
}
