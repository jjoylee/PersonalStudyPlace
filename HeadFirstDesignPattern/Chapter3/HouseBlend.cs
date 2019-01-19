using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(BeverageSize bSize)
        {
            description = "하우스 블랜드 커피";
            setSize(bSize);
        }

        public override double cost()
        {
            return .89 + calcSizeCose();
        }
    }
}
