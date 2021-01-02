using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface FlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("날고 있어요!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("저는 못날아요!");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("로켓 추진으로 날아갑니다.");
        }
    }
}
