using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class CeilingFanOnCommand : Command
    {
        CeilingFan ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            ceilingFan.on();
        }

        public void undo()
        {
            ceilingFan.on();
        }
    }
}
