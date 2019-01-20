using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    // Factory Pattern

    // 객체 생성 부분을 캡슐화한다.
    // 팩토리 메소드 패턴 - 어떤 클래스의 인스턴스를 만들지 서브클래스에서 결정한다.
    // 추상화된 것에 의존하도록 만든다. 구상 클래스에 의존하도록 만들지 않는다.
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            
            Console.WriteLine("Joel orderd a " + pizza.getName());
        }
    }
}
