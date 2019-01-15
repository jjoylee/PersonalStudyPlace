using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("저는 못 날아요");
        }
    }
}
