using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class SteamMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 스팀 밀크";
        }
    }
}
