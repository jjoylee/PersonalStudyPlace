using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class GumballMachine : MarshalByRefObject, IGumballMachineRemote
    {
        static State soldOutState;
        
        static State noQuarterState;
        static State hasQuarterState;
        static State soldState;
        static State winnerState;

        private State state = soldOutState;
        string location;
        int count = 0;
        
        public GumballMachine(string location, int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.count = count;
            if (count > 0) state = noQuarterState;
            this.location = location;
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

        public int getCount()
        {
            return count;
        }

        public string getLocation()
        {
            return location;
        }

        public State getState()
        {
            return state;
        }
    }
}
