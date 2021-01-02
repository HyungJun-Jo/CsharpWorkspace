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
            quackBehavior = new QuackQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("저는 물오리 입니다!");
        }
    }
}
