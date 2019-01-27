using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    public abstract class CaffeineBeverage
    {
        // Template Method
        // 어떤 알고리즘에 대한 템플릿(틀) 역할을 한다.
        // 카페인 음료를 만들기 위한 알고리즘에 대한 템플릿
        // 템플릿 메소드에서는 알고리즘의 각 단계들을 정의.
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments(); // 조미료
            }
        }

        public abstract void addCondiments();

        private void pourInCup()
        {
            Console.WriteLine("컵에 따르는 중");
        }

        public abstract void brew();

        private void boilWater()
        {
            Console.WriteLine("물 끓이는 중");
        }

        // hook - 필요에 따라 서브클래스에서 오버라이드
        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
