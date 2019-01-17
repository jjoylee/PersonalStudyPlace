﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public abstract class Beverage
    {
        protected string description = "제목 없음";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
