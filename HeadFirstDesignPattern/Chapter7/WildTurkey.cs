using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
