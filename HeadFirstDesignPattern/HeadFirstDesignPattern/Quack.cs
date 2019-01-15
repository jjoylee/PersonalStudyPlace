using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("꿱");
        }
    }
}
