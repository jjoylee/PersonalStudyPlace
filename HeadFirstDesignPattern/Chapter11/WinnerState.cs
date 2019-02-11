using System;

namespace Chapter11
{
    [Serializable]
    public class WinnerState : State
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("축하드립니다! 알맹이를 하나 더 받으실 수 있습니다.");
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
                gumballMachine.setState(gumballMachine.getSoldOutState());
            else
            {
                gumballMachine.releaseBall();
                if (gumballMachine.getCount() > 0)
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                else
                {
                    Console.WriteLine("더 이상 알맹이가 없습니다.");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
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