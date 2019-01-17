using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "에스프레소";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
