using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    // State Pattern
    // 객체의 내부 상태가 바뀜에 따라서 객체의 행동을 바꾼다.
    // 상태를 별도의 클래스로 캡슐화
    // 행동을 상태 객체 내에 캡슐화시킨다.
    // 객체의 내부 상태에 따라 현재 상태를 나타내는 객체가 바뀌게 된다.
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            //gumballMachine.ejectQuarter();

            //Console.WriteLine(gumballMachine);

            //gumballMachine.insertQuarter();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();

            //Console.WriteLine(gumballMachine);
        }
    }
}
