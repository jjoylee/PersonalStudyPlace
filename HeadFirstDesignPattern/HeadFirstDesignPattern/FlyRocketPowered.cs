using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("로켓 추진으로 날아갑니다");
        }
    }
}
