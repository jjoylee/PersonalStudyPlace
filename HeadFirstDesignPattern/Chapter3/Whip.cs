using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 휘핑 크림";
        }
    }
}
