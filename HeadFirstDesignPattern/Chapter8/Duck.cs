using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    public class Duck : IComparable
    {
        public string name;
        public int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(object obj)
        {
            Duck otherDuck = (Duck)obj;
            if (this.weight < otherDuck.weight) return -1;
            if (this.weight == otherDuck.weight) return 0;
            return 1;
        }

        public override string ToString()
        {
            return name + ", 체중 : " + weight;
        }
    }
}
