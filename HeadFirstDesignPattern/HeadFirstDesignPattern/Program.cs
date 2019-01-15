using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    // Strategy Pattern

    // 애플리케이션에서 달라지는 부분을 찾아내고, 달라지지 않는 부분으로부터 분리시킨다.
    // -> 달라지는 부분을 찾아서 나머지 코드에 영향을 주지 않도록 '캡슐화'한다.
    // 구현이 아닌 인터페이스에 맞춰서 프로그래밍한다.
    // 상속보다는 구성을 활용한다.

    // 알고리즘군을 정의하고 각각을 캡슐화하여 교환해서 사용할 수 있도록 한다.
    // 알고리즘을 사용하는 클라이언트와는 독립적으로 알고리즘을 변경할 수 있다.
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
