using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    public class Tea : CaffeineBeverage
    {
        //public void prepareRecipe()
        //{
        //    boilWater();
        //    steepTeaBag();
        //    pourInCup();
        //    addLemon();
        //}
        

        //private void pourInCup()
        //{
        //    Console.WriteLine("컵에 따르는 중");
        //}

        //private void boilWater()
        //{
        //    Console.WriteLine("물 끓이는 중");
        //}

        public override void addCondiments()
        {
            Console.WriteLine("레몬을 추가하는 중");
        }

        public override void brew()
        {
            Console.WriteLine("차를 우려내는 중");
        }
    }
}
