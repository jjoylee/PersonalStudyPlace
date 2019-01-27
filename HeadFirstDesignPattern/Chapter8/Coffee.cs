using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    public class Coffee : CaffeineBeverage
    {
        //public void prepareRecipe()
        //{
        //    boilWater();
        //    brewCoffeeGrinds();
        //    pourInCup();
        //    addSugarAndMilk();
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
            Console.WriteLine("설탕과 우유를 추가하는 중");
        }

        public override void brew()
        {
            Console.WriteLine("필터를 통해 커피를 우려내는 중");
        }

        public override bool customerWantsCondiments()
        {
            string answer = getUserInput();
            if (answer.ToLower().Equals("y")) return true;
            return false;
        }

        private string getUserInput()
        {
            string answer = null;
            Console.WriteLine("커피에 우유와 설탕을 넣어 드릴까요? (y/n)");
            answer = Console.ReadLine();
            if (answer == null) return "no";
            return answer;
        }
    }
}
