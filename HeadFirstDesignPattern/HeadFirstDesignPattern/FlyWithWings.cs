using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("날고 있어요!!");
        }
    }
}
