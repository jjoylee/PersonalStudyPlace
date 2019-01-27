using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    // Template Method Pattern
    // 메소드에서 알고리즘의 골격을 정의
    // 알고리즘의 구조는 그대로 유지하면서 서브클래스에서 특정 단계를 재정의 할 수 있다.
    // 알고리즘의 틀을 만들기 위함
    class Program
    {
        static void Main(string[] args)
        {
            Tea myTea = new Tea();
            Coffee myCoffee = new Coffee();
            myTea.prepareRecipe();
            myCoffee.prepareRecipe();

            Duck[] ducks = { new Duck("Daffy",8), new Duck("Dewey", 2), new Duck("Howard", 7),
            new Duck("Louie",2) , new Duck("Donald",10), new Duck("Huey",2)};
            Array.Sort(ducks);
            display(ducks);
        }

        private static void display(Duck[] ducks)
        {
            foreach(Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
