using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
