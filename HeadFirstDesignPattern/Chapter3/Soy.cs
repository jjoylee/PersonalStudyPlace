using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage; 
        }

        public override double cost()
        {
            return beverage.cost() + .15;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", 두유";
        }
    }
}
