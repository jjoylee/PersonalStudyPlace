using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    public abstract class Duck
    {
        // fly, quack 부분에서만 계속 변한다. 이부분만 인터페이스로 뺴서 캡슐화
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck() { }

        // abstract와 virtual의 차이

        // 1.abstract
        // 사용하려면 해당 클래스도 abstract여야한다.  
        // 속성이나 메소드는 본문을 정의할 수 없다. 
        // public, internal, protected -> 상속을 해야하기 때문에 private 불가

        // 2.virtual
        // 정적 클래스를 제외한 모든 클래스에서 사용 가능하다.
        // 속성이나 메서드는 본문을 정의할 수 있다.

        public abstract void display();

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void swim()
        {
            Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠");
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
