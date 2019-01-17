using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 모카";
        }
    }
}
