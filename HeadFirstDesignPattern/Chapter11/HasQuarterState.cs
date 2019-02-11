using System;

namespace Chapter11
{
    [Serializable]
    public class HasQuarterState : State
    {
        private Random randomWinner = new Random();
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("알맹이가 나갈 수 없습니다.");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("동전이 반환됩니다.");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("동전은 한 개만 넣어주세요");
        }

        public void turnCrank()
        {
            Console.WriteLine("손잡이를 돌리셨습니다.");
            int winner = randomWinner.Next(10);
            if((winner == 0) && gumballMachine.getCount() > 1)
                gumballMachine.setState(gumballMachine.getWinnerState());
            else gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}