using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public abstract class Beverage
    {
        protected string description = "제목 없음";
        private BeverageSize size;

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();

        public void setSize(BeverageSize size)
        {
            this.size = size;
        }

        public BeverageSize getSize()
        {
            return this.size;
        }

        public double calcSizeCose()
        {
            if (size == BeverageSize.TALL) return .20;
            if (size == BeverageSize.GRANDE) return .25;
            return .30;
        }
    }
}
