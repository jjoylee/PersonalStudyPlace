using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            ceilingFan.off();
        }

        public void undo()
        {
            ceilingFan.on();
        }
    }
}
