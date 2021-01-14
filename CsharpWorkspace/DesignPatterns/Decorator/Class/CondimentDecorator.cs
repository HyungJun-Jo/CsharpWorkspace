using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        //public abstract string GetDescription();          // 해당 부분 작동을 제대로 안함
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 모카";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }

    public class SteamMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 스팀밀크";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }

    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 두유";
        }

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 휘핑크림";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }

}
