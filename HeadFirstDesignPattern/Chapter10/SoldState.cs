using System;

namespace Chapter10
{
    internal class SoldState : State
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            gumballMachine.releaseBall();
            if(gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
        }

        public void insertQuarter()
        {
            Console.WriteLine("잠깐만 기다려 주세요, 알맹이가 나가고 있습니다.");
        }

        public void turnCrank()
        {
            Console.WriteLine("손잡이는 한번만 돌려주세요");
        }
    }
}