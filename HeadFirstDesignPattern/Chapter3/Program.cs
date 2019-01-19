using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    // Decorator Pattern

    // 객체에 추가적인 요건을 동적으로 첨가한다.
    // 서브클래스를 만드는 것을 통해서 기능을 유연하게 확장할 수 있는 방법을 제공한다.

    // 클래스는 확장에 대해서는 열려있어야 하지만 코드 변경에 대해서는 닫혀 있어야 한다.
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso(BeverageSize.TALL);
            Console.WriteLine(beverage.getDescription() + "$" + beverage.cost());

            Beverage beverage2 = new DarkRoast(BeverageSize.TALL);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend(BeverageSize.TALL);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());
        }
    }
}
