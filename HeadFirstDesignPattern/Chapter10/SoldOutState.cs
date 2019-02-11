using System;

namespace Chapter10
{
    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("매진되었습니다. 다음 기회에 이용해주세요.");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("매진되었습니다. 다음 기회에 이용해주세요.");
        }

        public void insertQuarter()
        {
            Console.WriteLine("매진되었습니다. 다음 기회에 이용해주세요.");
        }

        public void turnCrank()
        {
            Console.WriteLine("매진되었습니다. 다음 기회에 이용해주세요.");
        }
    }
}