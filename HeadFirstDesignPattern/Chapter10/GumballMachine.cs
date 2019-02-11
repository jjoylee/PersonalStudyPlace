using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    public class GumballMachine
    {
        //const int SOLD_OUT = 0;
        //const int NO_QUARTER = 1;
        //const int HAS_QUARTER = 2;
        //const int SOLD = 3;

        //int state = SOLD_OUT;

        static State soldOutState;

        public int getCount()
        {
            return count;
        }

        static State noQuarterState;
        static State hasQuarterState;
        static State soldState;
        static State winnerState;

        private State state = soldOutState;

        int count = 0;

        //public GumballMachine(int count)
        //{
        //    this.count = count;
        //    if (count > 0) state = NO_QUARTER;
        //}

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.count = numberGumballs;
            if (numberGumballs > 0) state = noQuarterState;
        }

        public State getWinnerState()
        {
            return winnerState;
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        //public void insertQuarter()
        //{
        //    if (state == HAS_QUARTER)
        //        Console.WriteLine("동전은 한 개만 넣어주세요");
        //    else if(state == NO_QUARTER)
        //    {
        //        state = HAS_QUARTER;
        //        Console.WriteLine("동전을 넣으셨습니다.");
        //    }
        //    else if(state == SOLD_OUT)
        //        Console.WriteLine("매진되었습니다. 다음 기회에 이용해주세요.");
        //    else if(state == SOLD)
        //        Console.WriteLine("잠깐만 기다려 주세요.. 알맹이가 나가고 있습니다.");
        //}

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot....");
            if (count != 0) count -= 1;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        //public void ejectQuarter()
        //{
        //    if(state == HAS_QUARTER)
        //    {
        //        Console.WriteLine("동전이 반환됩니다.");
        //        state = NO_QUARTER;
        //    } else if(state == NO_QUARTER)
        //    {
        //        Console.WriteLine("동전을 넣어주세요.");
        //    } else if(state == SOLD)
        //    {
        //        Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
        //    } else if(state == SOLD_OUT)
        //    {
        //        Console.WriteLine("동전을 넣지 않으셨습니다. 동전이 반환되지 않습니다.");
        //    }
        //}

        //public void turnCrank()
        //{
        //    if(state == SOLD)
        //    {
        //        Console.WriteLine("손잡이는 한 번만 돌려주세요");
        //    } else if(state == NO_QUARTER)
        //    {
        //        Console.WriteLine("동전을 넣어주세요");
        //    } else if(state == SOLD_OUT)
        //    {
        //        Console.WriteLine("매진되었습니다.");
        //    }else if(state == HAS_QUARTER)
        //    {
        //        Console.WriteLine("손잡이를 돌리셨습니다.");
        //        state = SOLD;
        //        dispense();
        //    }
        //}

        //public void dispense()
        //{
        //    if(state == SOLD)
        //    {
        //        Console.WriteLine("알맹이가 나가고 잇습니다.");
        //        count = count - 1;
        //        if(count == 0)
        //        {
        //            Console.WriteLine("더 이상 알맹이가 없습니다.");
        //            state = SOLD_OUT;
        //        } else
        //        {
        //            state = NO_QUARTER;
        //        }
        //    } else if(state == NO_QUARTER)
        //    {
        //        Console.WriteLine("동전을 넣어주세요");
        //    } else if(state == SOLD_OUT)
        //    {
        //        Console.WriteLine("매진입니다.");
        //    } else if(state == HAS_QUARTER)
        //    {
        //        Console.WriteLine("알맹이가 나갈 수 없습니다.");
        //    }
        //}
    }
}
