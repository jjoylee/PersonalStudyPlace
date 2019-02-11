using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class GumballMonitor
    {
        IGumballMachineRemote _gumballMachine;

        public GumballMonitor(IGumballMachineRemote gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void report()
        {
            Console.WriteLine("뽑기 기계 위치 : " + _gumballMachine.getLocation());
            Console.WriteLine("현재 재고 : " + _gumballMachine.getCount());
            Console.WriteLine("현재 상태 : " + _gumballMachine.getState());
        }
    }
}
