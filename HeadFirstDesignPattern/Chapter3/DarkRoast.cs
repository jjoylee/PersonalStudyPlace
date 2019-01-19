using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(BeverageSize bSize)
        {
            description = "다크 로스트";
            setSize(bSize);
        }
        public override double cost()
        {
            return .99 + calcSizeCose();
        }
    }
}
