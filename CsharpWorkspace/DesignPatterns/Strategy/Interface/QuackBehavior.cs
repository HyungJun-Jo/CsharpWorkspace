using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface QuackBehavior
    {
        void Quack();
    }

    public class QuackQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("조용~");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("삑");
        }
    }
}
